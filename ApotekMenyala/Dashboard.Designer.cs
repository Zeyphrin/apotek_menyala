namespace ApotekMenyala
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button_PasienBaru = new Button();
            button1 = new Button();
            panel2 = new Panel();
            TextBox_Search = new ReaLTaiizor.Controls.PoisonTextBox();
            button_Close = new Button();
            dataGridView1 = new DataGridView();
            button_Search = new Button();
            button_PrintPDF = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button_PasienBaru);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 732);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(0, 670);
            button3.Name = "button3";
            button3.Size = new Size(206, 62);
            button3.TabIndex = 0;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button_PasienBaru
            // 
            button_PasienBaru.BackColor = Color.Ivory;
            button_PasienBaru.FlatStyle = FlatStyle.Flat;
            button_PasienBaru.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_PasienBaru.Location = new Point(0, 276);
            button_PasienBaru.Name = "button_PasienBaru";
            button_PasienBaru.Size = new Size(206, 62);
            button_PasienBaru.TabIndex = 0;
            button_PasienBaru.Text = "Pasien Baru";
            button_PasienBaru.UseVisualStyleBackColor = false;
            button_PasienBaru.Click += button_PasienBaru_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 208);
            button1.Name = "button1";
            button1.Size = new Size(206, 62);
            button1.TabIndex = 0;
            button1.Text = "Data Pasien";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(TextBox_Search);
            panel2.Controls.Add(button_Close);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button_Search);
            panel2.Controls.Add(button_PrintPDF);
            panel2.Location = new Point(212, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 644);
            panel2.TabIndex = 2;
            // 
            // TextBox_Search
            // 
            // 
            // 
            // 
            TextBox_Search.CustomButton.Image = null;
            TextBox_Search.CustomButton.Location = new Point(273, 2);
            TextBox_Search.CustomButton.Name = "";
            TextBox_Search.CustomButton.Size = new Size(23, 23);
            TextBox_Search.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_Search.CustomButton.TabIndex = 1;
            TextBox_Search.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_Search.CustomButton.UseSelectable = true;
            TextBox_Search.CustomButton.Visible = false;
            TextBox_Search.Location = new Point(516, 44);
            TextBox_Search.MaxLength = 32767;
            TextBox_Search.Name = "TextBox_Search";
            TextBox_Search.PasswordChar = '\0';
            TextBox_Search.ScrollBars = ScrollBars.None;
            TextBox_Search.SelectedText = "";
            TextBox_Search.SelectionLength = 0;
            TextBox_Search.SelectionStart = 0;
            TextBox_Search.ShortcutsEnabled = true;
            TextBox_Search.Size = new Size(299, 28);
            TextBox_Search.TabIndex = 4;
            TextBox_Search.UseSelectable = true;
            TextBox_Search.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Search.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // button_Close
            // 
            button_Close.BackColor = Color.IndianRed;
            button_Close.FlatStyle = FlatStyle.Flat;
            button_Close.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Close.ForeColor = SystemColors.ControlText;
            button_Close.Location = new Point(805, 594);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(112, 42);
            button_Close.TabIndex = 3;
            button_Close.Text = "Close";
            button_Close.UseVisualStyleBackColor = false;
            button_Close.Click += button_Close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 510);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_Search
            // 
            button_Search.BackColor = Color.DarkSeaGreen;
            button_Search.FlatStyle = FlatStyle.Flat;
            button_Search.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Search.Location = new Point(821, 44);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(96, 28);
            button_Search.TabIndex = 1;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = false;
            button_Search.Click += button_Search_Click;
            // 
            // button_PrintPDF
            // 
            button_PrintPDF.BackColor = Color.Ivory;
            button_PrintPDF.FlatStyle = FlatStyle.Flat;
            button_PrintPDF.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_PrintPDF.Location = new Point(13, 594);
            button_PrintPDF.Name = "button_PrintPDF";
            button_PrintPDF.Size = new Size(102, 42);
            button_PrintPDF.TabIndex = 1;
            button_PrintPDF.Text = "Print PDF";
            button_PrintPDF.UseVisualStyleBackColor = false;
            button_PrintPDF.Click += button_PrintPDF_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(212, 27);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(193, 46);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "Data Pasien";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 732);
            Controls.Add(bigLabel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button_PasienBaru;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button_PrintPDF;
        private Button button_Close;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Search;
        private Button button_Search;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
    }
}