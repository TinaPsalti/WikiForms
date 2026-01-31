using System.Data;
using System.Data.SQLite;


namespace ergasia3_aae
{
    //Διαχείρηση SQLite βάσης αγαπημένων 
    public class Db
    {
        //Αρχείο βάσης
        private string cs = "Data Source=favorites.db";

        //Δημιουργία του πίνακα Favourites αν δεν υπάρχει
        public void Init()
        {
            using var con = new SQLiteConnection(cs);
            con.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Favorites(
                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Title TEXT,
                            Url TEXT
                           )";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        //Προσθήκη εγγραφής στα αγαπημένα
        public void Add(string title, string url)
        {
            using var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(
                "INSERT INTO Favorites (Title, Url) VALUES (@t, @u)", con);

            cmd.Parameters.AddWithValue("@t", title);
            cmd.Parameters.AddWithValue("@u", url);
            cmd.ExecuteNonQuery();
        }

        //Επιστροφή όλων των αγαπημένων
        public DataTable GetAll() 
        {
            using var con = new SQLiteConnection(cs);
            con.Open();

            var da = new SQLiteDataAdapter(
                "SELECT Id, Title, Url FROM Favorites", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Διαγραφή με βάση το primary key ID
        public void Delete(long id)
        {
            using var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(
                "DELETE FROM Favorites WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
