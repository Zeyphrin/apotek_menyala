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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            poisonTextBox3 = new ReaLTaiizor.Controls.PoisonTextBox();
            button6 = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 732);
            panel1.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(poisonTextBox3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(212, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 644);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.Ivory;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(13, 594);
            button5.Name = "button5";
            button5.Size = new Size(102, 42);
            button5.TabIndex = 1;
            button5.Text = "Print PDF";
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 510);
            dataGridView1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(805, 594);
            button4.Name = "button4";
            button4.Size = new Size(112, 42);
            button4.TabIndex = 3;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            // 
            // poisonTextBox3
            // 
            // 
            // 
            // 
            poisonTextBox3.CustomButton.Image = null;
            poisonTextBox3.CustomButton.Location = new Point(273, 2);
            poisonTextBox3.CustomButton.Name = "";
            poisonTextBox3.CustomButton.Size = new Size(23, 23);
            poisonTextBox3.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            poisonTextBox3.CustomButton.TabIndex = 1;
            poisonTextBox3.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            poisonTextBox3.CustomButton.UseSelectable = true;
            poisonTextBox3.CustomButton.Visible = false;
            poisonTextBox3.Location = new Point(516, 44);
            poisonTextBox3.MaxLength = 32767;
            poisonTextBox3.Name = "poisonTextBox3";
            poisonTextBox3.PasswordChar = '\0';
            poisonTextBox3.ScrollBars = ScrollBars.None;
            poisonTextBox3.SelectedText = "";
            poisonTextBox3.SelectionLength = 0;
            poisonTextBox3.SelectionStart = 0;
            poisonTextBox3.ShortcutsEnabled = true;
            poisonTextBox3.Size = new Size(299, 28);
            poisonTextBox3.TabIndex = 4;
            poisonTextBox3.UseSelectable = true;
            poisonTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
            poisonTextBox3.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // button6
            // 
            button6.BackColor = Color.PowderBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(821, 44);
            button6.Name = "button6";
            button6.Size = new Size(96, 28);
            button6.TabIndex = 1;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(212, 9);
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
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private ReaLTaiizor.Controls.PoisonTextBox poisonTextBox3;
        private Button button6;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}