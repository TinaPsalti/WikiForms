using Newtonsoft.Json;
using System.Speech.Synthesis;


namespace ergasia3_aae
{
    public partial class Form1 : Form
    {
        //Αποτέλεσμα της τελευταίας αναζήτησης
        private WikiResp? current;
        
        //Speech synthesizer για ανάγνωση
        private SpeechSynthesizer speaker = new SpeechSynthesizer();

        //Flag για έλεγχο χρήσης ελληνικών
        bool isGreek = false;

        //Βάση δεδομένων για αγαπημένα
        private Db db = new Db();

        public Form1()
        {
            InitializeComponent();

            //Αρχικοποίηση placeholder και βάσης 
            ShowPlaceholder();
            db.Init();

            //Φόρτωση αγαπημένων
            LoadFavorites();
        }

        //Φόρτωση αγαπημένων από την βάση
        private void LoadFavorites()
        {
            dataGridView1.DataSource = db.GetAll();
        }

        //Εμφάνιση προεπιλεγμένης εικόνας
        private void ShowPlaceholder()
        {
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "Images", "wiki.jpg");
        }

        private void speakBtn_Click(object sender, EventArgs e)
        {
            //Ανάγνωση κειμένου
            string text = richTextBox1.Text.Trim();

            //Έλεγχος ύπαρξης κειμένου
            if (text == "")
            {
                MessageBox.Show("Δεν υπάρχει κείμενο.");
                return;
            }

            //Καθαρισμός κειμένου πριν από την ανάγνωση 
            text = text.Replace("(", "").Replace(")", "").Replace("/", "");

            //Διακοπή προηγούμενης ανάγνωσης αν υπάρχει
            speaker.SpeakAsyncCancelAll();
            try
            {
                //Χρήση της ελληνικής φωνής αν είναι εγκατεστημένη
                speaker.SelectVoice("Microsoft Stefanos");
            }
            catch { }
            //Ανάγνωση κειμένου
            speaker.SpeakAsync(text);
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            isGreek = false;

            string term = searchbox.Text.Trim();

            //Έλεγχος κενής εισόδου
            if (term == "")
            {
                MessageBox.Show("Γράψε έναν όρο αναζήτησης.");
                return;
            }

            //Έλεγχος για χρήση ελληνικών χαρακτήρων, αριθμών και συμβόλων 
            isGreek = true;

            foreach (char c in term)
            {
                if (c == ' ')
                    continue;

                if ((c >= 'Α' && c <= 'Ω') || (c >= 'α' && c <= 'ω') || c == 'ς')
                    continue;

                if (c >= '0' && c <= '9')
                    continue;

                if (c == '-' || c == ',' || c == '.' || c == '(' || c == ')' || c == '΄' || c == '\'')
                    continue;

                isGreek = false;
                break;
            }

            //Εμφάνιση μηνύματος σε περίπτωση μη ελληνικής αναζήτησης.
            if (!isGreek)
            {
                MessageBox.Show("Παρακαλώ εισάγετε τον όρο στα ελληνικά.");
                current = null;
                return;
            }

            //Url που καλούμε στο Wikipedia API(ο όρος που αναζητά ο χρήστης(term) γίνεται URL-encoded για την αποφυγή errors)
            string url = "https://el.wikipedia.org/api/rest_v1/page/summary/" + Uri.EscapeDataString(term);

            //Χρήση ΗttpClient για την αποστολή request και την ληψη απάντησης από Wikipedia API 
            using HttpClient client = new HttpClient();

            //Ασύνχρονο responce από το API
            var resp = await client.GetAsync(url);

            //Λήψη JSON και μετατροπή σε αντικείμενο
            string json = await resp.Content.ReadAsStringAsync();

            current = JsonConvert.DeserializeObject<WikiResp>(json);

            if (current == null || current.title == null)
            {
                MessageBox.Show("Δεν βρέθηκε λήμμα.");
                ShowPlaceholder();
                titleLabel.Text = "";
                richTextBox1.Text = "";
                return;
            }
            //Ενημέρωση τίτλου και σύνοψης
            titleLabel.Text = current.title ?? "";
            richTextBox1.Text = current.extract ?? "";

            //Φόρτωση εικόνας
            if (current.thumbnail?.source != null)
            {
                try
                {
                    pictureBox1.Load(current.thumbnail.source);
                }
                catch
                {
                    //Σε αποτυχία, χρήση προεπιλεγμένης εικονας
                    ShowPlaceholder();
                }
            }
            else
            {
                //αν δεν παρεχεται εικόνα απο το API: πάλι χρήση της προεπιλεγμένης εικόνας
                ShowPlaceholder();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                { return; }

            //Επιλεγμένη γραμμή
            var row = dataGridView1.CurrentRow;

            //Τιμή του πεδίου της στήλης Id
            var cellValue = row.Cells["Id"].Value;

            //Μετατροπή σε long
            long id = (long)cellValue;

            //Διαγραφή από την βάση
            db.Delete(id);

            //Ανανέωση πίνακα αγαπημένων
            LoadFavorites();
        }

        private void favbtn_Click(object sender, EventArgs e)
        {
            //Έλεγχος ύπαρξης αναζήτησης
            if (current == null)
            {
                MessageBox.Show("Παρακαλώ κάντε πρώτα αναζήτηση");
                return;
            }

            string title = current.title ?? "";
            string url = current.content_urls?.desktop?.page ?? "";

            //Έλεγχος ύπαρξης δεδομένων
            if (title == "" || url == "")
            {
                MessageBox.Show("Δεν υπάρχουν δεδομένα.");
                return;
            }

            //Έλεγχος για αποφυγή διπλής εγγραφής 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Url"].Value.ToString() == url)
                {
                    MessageBox.Show("Η αναζήτηση υπάρχει ήδη στην λίστα αγαπημένων");
                    return;
                }
            }

            //Εισαγωγή δεδομένων στην βάση και ανανέωση του πίνακα  
            db.Add(title,url);
            LoadFavorites();
        }


        public class WikiResp
        {
            //Τίτλος
            public string? title { get; set; }

            //Κείμενο
            public string? extract { get; set; }

            //Εικόνα
            public Thumbnail? thumbnail { get; set; }

            //Url
            public ContentUrls? content_urls { get; set; }
        }

        public class Thumbnail
        {
            //Url εικόνας
            public string? source { get; set; }
        }

        public class ContentUrls
        {
            public Desktop? desktop { get; set; }
        }

        public class Desktop
        {
            //Url της σελίδας
            public string? page { get; set; }
        }

    }
}
