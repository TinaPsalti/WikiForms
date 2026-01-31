namespace ergasia3_aae
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchbox = new TextBox();
            searchBtn = new Button();
            speakBtn = new Button();
            favbtn = new Button();
            delBtn = new Button();
            titleLabel = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            Favourites = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            Favourites.SuspendLayout();
            SuspendLayout();
            // 
            // searchbox
            // 
            searchbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchbox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbox.Location = new Point(33, 22);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(472, 30);
            searchbox.TabIndex = 0;
            searchbox.Text = "..";
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(526, 9);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(105, 30);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Αναζήτηση";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // speakBtn
            // 
            speakBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            speakBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            speakBtn.Location = new Point(634, 9);
            speakBtn.Name = "speakBtn";
            speakBtn.Size = new Size(105, 30);
            speakBtn.TabIndex = 2;
            speakBtn.Text = "Ακρόαση";
            speakBtn.UseVisualStyleBackColor = true;
            speakBtn.Click += speakBtn_Click;
            // 
            // favbtn
            // 
            favbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            favbtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            favbtn.Location = new Point(526, 42);
            favbtn.Name = "favbtn";
            favbtn.Size = new Size(213, 30);
            favbtn.TabIndex = 3;
            favbtn.Text = "Προσθήκη στα Αγαπημένα";
            favbtn.UseVisualStyleBackColor = true;
            favbtn.Click += favbtn_Click;
            // 
            // delBtn
            // 
            delBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(691, 123);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(94, 29);
            delBtn.TabIndex = 4;
            delBtn.Text = "Διαγραφή";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(98, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 22);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "label1";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(468, 171);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(788, 135);
            dataGridView1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(Favourites, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(searchbox);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(speakBtn);
            panel1.Controls.Add(favbtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 74);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(titleLabel);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 197);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Περιγραφή";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(483, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 197);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Εικόνα";
            // 
            // Favourites
            // 
            tableLayoutPanel1.SetColumnSpan(Favourites, 2);
            Favourites.Controls.Add(delBtn);
            Favourites.Controls.Add(dataGridView1);
            Favourites.Dock = DockStyle.Fill;
            Favourites.Location = new Point(3, 286);
            Favourites.Name = "Favourites";
            Favourites.Size = new Size(794, 161);
            Favourites.TabIndex = 8;
            Favourites.TabStop = false;
            Favourites.Text = "Αγαπημένα";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            Favourites.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchbox;
        private Button searchBtn;
        private Button speakBtn;
        private Button favbtn;
        private Button delBtn;
        private Label titleLabel;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox Favourites;
        private GroupBox groupBox2;
    }
}
