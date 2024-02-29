namespace ApotekMenyala
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            panel2 = new Panel();
            panel4 = new Panel();
            RadioButton_NonSub = new ReaLTaiizor.Controls.PoisonRadioButton();
            label3 = new Label();
            RadioButton_Subsidi = new ReaLTaiizor.Controls.PoisonRadioButton();
            panel3 = new Panel();
            CheckBox_Malam = new ReaLTaiizor.Controls.PoisonCheckBox();
            CheckBox_Siang = new ReaLTaiizor.Controls.PoisonCheckBox();
            CheckBox_Pagi = new ReaLTaiizor.Controls.PoisonCheckBox();
            RadioButton_3Kali = new ReaLTaiizor.Controls.PoisonRadioButton();
            RadioButton_2Kali = new ReaLTaiizor.Controls.PoisonRadioButton();
            RadioButton_1Kali = new ReaLTaiizor.Controls.PoisonRadioButton();
            ComboBox_JenisObat = new ReaLTaiizor.Controls.PoisonComboBox();
            RadioButton_TidakAlergi = new ReaLTaiizor.Controls.PoisonRadioButton();
            RadioButton_Alergi = new ReaLTaiizor.Controls.PoisonRadioButton();
            TextBox_Keluhan = new ReaLTaiizor.Controls.PoisonTextBox();
            TextBox_NamaObat = new ReaLTaiizor.Controls.PoisonTextBox();
            TextBox_NamaPasien = new ReaLTaiizor.Controls.PoisonTextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            button5 = new Button();
            button7 = new Button();
            button_Create = new Button();
            button4 = new Button();
            panel5 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(ComboBox_JenisObat);
            panel2.Controls.Add(RadioButton_TidakAlergi);
            panel2.Controls.Add(RadioButton_Alergi);
            panel2.Controls.Add(TextBox_Keluhan);
            panel2.Controls.Add(TextBox_NamaObat);
            panel2.Controls.Add(TextBox_NamaPasien);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button_Create);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(225, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 643);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(RadioButton_NonSub);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(RadioButton_Subsidi);
            panel4.Location = new Point(3, 267);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 77);
            panel4.TabIndex = 6;
            // 
            // RadioButton_NonSub
            // 
            RadioButton_NonSub.AutoSize = true;
            RadioButton_NonSub.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_NonSub.Location = new Point(116, 38);
            RadioButton_NonSub.Name = "RadioButton_NonSub";
            RadioButton_NonSub.Size = new Size(98, 19);
            RadioButton_NonSub.TabIndex = 3;
            RadioButton_NonSub.Text = "Non Subsidi";
            RadioButton_NonSub.UseSelectable = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 8);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "Jenis Pasien";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RadioButton_Subsidi
            // 
            RadioButton_Subsidi.AutoSize = true;
            RadioButton_Subsidi.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_Subsidi.Location = new Point(3, 38);
            RadioButton_Subsidi.Name = "RadioButton_Subsidi";
            RadioButton_Subsidi.Size = new Size(107, 19);
            RadioButton_Subsidi.TabIndex = 3;
            RadioButton_Subsidi.Text = "Subsidi (BPJS)";
            RadioButton_Subsidi.UseSelectable = true;
            RadioButton_Subsidi.CheckedChanged += poisonRadioButton1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(CheckBox_Malam);
            panel3.Controls.Add(CheckBox_Siang);
            panel3.Controls.Add(CheckBox_Pagi);
            panel3.Controls.Add(RadioButton_3Kali);
            panel3.Controls.Add(RadioButton_2Kali);
            panel3.Controls.Add(RadioButton_1Kali);
            panel3.Location = new Point(393, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 86);
            panel3.TabIndex = 5;
            // 
            // CheckBox_Malam
            // 
            CheckBox_Malam.AutoSize = true;
            CheckBox_Malam.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            CheckBox_Malam.Location = new Point(122, 57);
            CheckBox_Malam.Name = "CheckBox_Malam";
            CheckBox_Malam.Size = new Size(67, 19);
            CheckBox_Malam.TabIndex = 4;
            CheckBox_Malam.Text = "Malam";
            CheckBox_Malam.UseSelectable = true;
            // 
            // CheckBox_Siang
            // 
            CheckBox_Siang.AutoSize = true;
            CheckBox_Siang.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            CheckBox_Siang.Location = new Point(122, 32);
            CheckBox_Siang.Name = "CheckBox_Siang";
            CheckBox_Siang.Size = new Size(58, 19);
            CheckBox_Siang.TabIndex = 4;
            CheckBox_Siang.Text = "Siang";
            CheckBox_Siang.UseSelectable = true;
            // 
            // CheckBox_Pagi
            // 
            CheckBox_Pagi.AutoSize = true;
            CheckBox_Pagi.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            CheckBox_Pagi.Location = new Point(122, 7);
            CheckBox_Pagi.Name = "CheckBox_Pagi";
            CheckBox_Pagi.Size = new Size(51, 19);
            CheckBox_Pagi.TabIndex = 4;
            CheckBox_Pagi.Text = "Pagi";
            CheckBox_Pagi.UseSelectable = true;
            // 
            // RadioButton_3Kali
            // 
            RadioButton_3Kali.AutoSize = true;
            RadioButton_3Kali.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_3Kali.Location = new Point(3, 57);
            RadioButton_3Kali.Name = "RadioButton_3Kali";
            RadioButton_3Kali.Size = new Size(58, 19);
            RadioButton_3Kali.TabIndex = 3;
            RadioButton_3Kali.Text = "3 Kali";
            RadioButton_3Kali.UseSelectable = true;
            RadioButton_3Kali.CheckedChanged += poisonRadioButton1_CheckedChanged;
            // 
            // RadioButton_2Kali
            // 
            RadioButton_2Kali.AutoSize = true;
            RadioButton_2Kali.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_2Kali.Location = new Point(3, 32);
            RadioButton_2Kali.Name = "RadioButton_2Kali";
            RadioButton_2Kali.Size = new Size(58, 19);
            RadioButton_2Kali.TabIndex = 3;
            RadioButton_2Kali.Text = "2 Kali";
            RadioButton_2Kali.UseSelectable = true;
            RadioButton_2Kali.CheckedChanged += poisonRadioButton1_CheckedChanged;
            // 
            // RadioButton_1Kali
            // 
            RadioButton_1Kali.AutoSize = true;
            RadioButton_1Kali.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_1Kali.Location = new Point(3, 7);
            RadioButton_1Kali.Name = "RadioButton_1Kali";
            RadioButton_1Kali.Size = new Size(58, 19);
            RadioButton_1Kali.TabIndex = 3;
            RadioButton_1Kali.Text = "1 Kali";
            RadioButton_1Kali.UseSelectable = true;
            RadioButton_1Kali.CheckedChanged += poisonRadioButton1_CheckedChanged;
            // 
            // ComboBox_JenisObat
            // 
            ComboBox_JenisObat.FormattingEnabled = true;
            ComboBox_JenisObat.ItemHeight = 23;
            ComboBox_JenisObat.Items.AddRange(new object[] { "Tablet", "Pil ", "Kapsul", "Sirup" });
            ComboBox_JenisObat.Location = new Point(393, 105);
            ComboBox_JenisObat.Name = "ComboBox_JenisObat";
            ComboBox_JenisObat.Size = new Size(302, 29);
            ComboBox_JenisObat.TabIndex = 4;
            ComboBox_JenisObat.UseSelectable = true;
            // 
            // RadioButton_TidakAlergi
            // 
            RadioButton_TidakAlergi.AutoSize = true;
            RadioButton_TidakAlergi.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_TidakAlergi.Location = new Point(459, 186);
            RadioButton_TidakAlergi.Name = "RadioButton_TidakAlergi";
            RadioButton_TidakAlergi.Size = new Size(96, 19);
            RadioButton_TidakAlergi.TabIndex = 3;
            RadioButton_TidakAlergi.Text = "Tidak Alergi";
            RadioButton_TidakAlergi.UseSelectable = true;
            // 
            // RadioButton_Alergi
            // 
            RadioButton_Alergi.AutoSize = true;
            RadioButton_Alergi.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            RadioButton_Alergi.Location = new Point(393, 186);
            RadioButton_Alergi.Name = "RadioButton_Alergi";
            RadioButton_Alergi.Size = new Size(60, 19);
            RadioButton_Alergi.TabIndex = 3;
            RadioButton_Alergi.Text = "Alergi";
            RadioButton_Alergi.UseSelectable = true;
            RadioButton_Alergi.CheckedChanged += poisonRadioButton1_CheckedChanged;
            // 
            // TextBox_Keluhan
            // 
            // 
            // 
            // 
            TextBox_Keluhan.CustomButton.Image = null;
            TextBox_Keluhan.CustomButton.Location = new Point(145, 2);
            TextBox_Keluhan.CustomButton.Name = "";
            TextBox_Keluhan.CustomButton.Size = new Size(151, 151);
            TextBox_Keluhan.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_Keluhan.CustomButton.TabIndex = 1;
            TextBox_Keluhan.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_Keluhan.CustomButton.UseSelectable = true;
            TextBox_Keluhan.CustomButton.Visible = false;
            TextBox_Keluhan.Location = new Point(3, 105);
            TextBox_Keluhan.MaxLength = 32767;
            TextBox_Keluhan.Name = "TextBox_Keluhan";
            TextBox_Keluhan.PasswordChar = '\0';
            TextBox_Keluhan.ScrollBars = ScrollBars.None;
            TextBox_Keluhan.SelectedText = "";
            TextBox_Keluhan.SelectionLength = 0;
            TextBox_Keluhan.SelectionStart = 0;
            TextBox_Keluhan.ShortcutsEnabled = true;
            TextBox_Keluhan.Size = new Size(299, 156);
            TextBox_Keluhan.TabIndex = 2;
            TextBox_Keluhan.UseSelectable = true;
            TextBox_Keluhan.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Keluhan.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // TextBox_NamaObat
            // 
            // 
            // 
            // 
            TextBox_NamaObat.CustomButton.Image = null;
            TextBox_NamaObat.CustomButton.Location = new Point(273, 2);
            TextBox_NamaObat.CustomButton.Name = "";
            TextBox_NamaObat.CustomButton.Size = new Size(23, 23);
            TextBox_NamaObat.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_NamaObat.CustomButton.TabIndex = 1;
            TextBox_NamaObat.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_NamaObat.CustomButton.UseSelectable = true;
            TextBox_NamaObat.CustomButton.Visible = false;
            TextBox_NamaObat.Location = new Point(393, 39);
            TextBox_NamaObat.MaxLength = 32767;
            TextBox_NamaObat.Name = "TextBox_NamaObat";
            TextBox_NamaObat.PasswordChar = '\0';
            TextBox_NamaObat.ScrollBars = ScrollBars.None;
            TextBox_NamaObat.SelectedText = "";
            TextBox_NamaObat.SelectionLength = 0;
            TextBox_NamaObat.SelectionStart = 0;
            TextBox_NamaObat.ShortcutsEnabled = true;
            TextBox_NamaObat.Size = new Size(299, 28);
            TextBox_NamaObat.TabIndex = 2;
            TextBox_NamaObat.UseSelectable = true;
            TextBox_NamaObat.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_NamaObat.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // TextBox_NamaPasien
            // 
            // 
            // 
            // 
            TextBox_NamaPasien.CustomButton.Image = null;
            TextBox_NamaPasien.CustomButton.Location = new Point(273, 2);
            TextBox_NamaPasien.CustomButton.Name = "";
            TextBox_NamaPasien.CustomButton.Size = new Size(23, 23);
            TextBox_NamaPasien.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_NamaPasien.CustomButton.TabIndex = 1;
            TextBox_NamaPasien.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_NamaPasien.CustomButton.UseSelectable = true;
            TextBox_NamaPasien.CustomButton.Visible = false;
            TextBox_NamaPasien.Location = new Point(3, 39);
            TextBox_NamaPasien.MaxLength = 32767;
            TextBox_NamaPasien.Name = "TextBox_NamaPasien";
            TextBox_NamaPasien.PasswordChar = '\0';
            TextBox_NamaPasien.ScrollBars = ScrollBars.None;
            TextBox_NamaPasien.SelectedText = "";
            TextBox_NamaPasien.SelectionLength = 0;
            TextBox_NamaPasien.SelectionStart = 0;
            TextBox_NamaPasien.ShortcutsEnabled = true;
            TextBox_NamaPasien.Size = new Size(299, 28);
            TextBox_NamaPasien.TabIndex = 2;
            TextBox_NamaPasien.UseSelectable = true;
            TextBox_NamaPasien.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_NamaPasien.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Keluhan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(393, 152);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 1;
            label7.Text = "Alergi Pasien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(393, 220);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 1;
            label6.Text = "Waktu Minum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(393, 82);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 1;
            label5.Text = "Jenis Obat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(393, 16);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 1;
            label4.Text = "Nama Obat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Pasien";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(895, 242);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(783, 598);
            button8.Name = "button8";
            button8.Size = new Size(112, 42);
            button8.TabIndex = 0;
            button8.Text = "Close";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(109, 598);
            button5.Name = "button5";
            button5.Size = new Size(112, 42);
            button5.TabIndex = 0;
            button5.Text = "Delete Data";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Khaki;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(736, 291);
            button7.Name = "button7";
            button7.Size = new Size(159, 38);
            button7.TabIndex = 0;
            button7.Text = "Clear ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button_Create
            // 
            button_Create.BackColor = Color.DarkSeaGreen;
            button_Create.FlatStyle = FlatStyle.Flat;
            button_Create.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Create.Location = new Point(736, 243);
            button_Create.Name = "button_Create";
            button_Create.Size = new Size(159, 42);
            button_Create.TabIndex = 0;
            button_Create.Text = "Create";
            button_Create.UseVisualStyleBackColor = false;
            button_Create.Click += button_Create_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1, 598);
            button4.Name = "button4";
            button4.Size = new Size(102, 42);
            button4.TabIndex = 0;
            button4.Text = "Edit Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(393, 152);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 65);
            panel5.TabIndex = 7;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(225, 28);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(190, 46);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Pasien Baru";
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
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 276);
            button2.Name = "button2";
            button2.Size = new Size(206, 62);
            button2.TabIndex = 0;
            button2.Text = "Pasien Baru";
            button2.UseVisualStyleBackColor = false;
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
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 732);
            panel1.TabIndex = 3;
            // 
            // AddData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 732);
            Controls.Add(panel1);
            Controls.Add(bigLabel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Label label1;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Keluhan;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_NamaPasien;
        private Label label2;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_NonSub;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_Subsidi;
        private Label label3;
        private ReaLTaiizor.Controls.PoisonComboBox ComboBox_JenisObat;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_NamaObat;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private ReaLTaiizor.Controls.PoisonCheckBox CheckBox_Malam;
        private ReaLTaiizor.Controls.PoisonCheckBox CheckBox_Siang;
        private ReaLTaiizor.Controls.PoisonCheckBox CheckBox_Pagi;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_3Kali;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_2Kali;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_1Kali;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_TidakAlergi;
        private ReaLTaiizor.Controls.PoisonRadioButton RadioButton_Alergi;
        private Label label7;
        private Button button7;
        private Button button_Create;
        private Button button8;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
    }
}