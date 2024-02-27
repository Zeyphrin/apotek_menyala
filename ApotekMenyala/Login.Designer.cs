namespace ApotekMenyala
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            button_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TextBox_Password = new ReaLTaiizor.Controls.PoisonTextBox();
            TextBox_Username = new ReaLTaiizor.Controls.PoisonTextBox();
            Button_Register = new Button();
            CheckBox_ShowPass = new ReaLTaiizor.Controls.PoisonCheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Ricardo Medium", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(406, 86);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(189, 42);
            bigLabel1.TabIndex = 4;
            bigLabel1.Text = "Login Page";
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.DarkSeaGreen;
            button_Login.FlatStyle = FlatStyle.Flat;
            button_Login.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Login.Location = new Point(403, 360);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(115, 33);
            button_Login.TabIndex = 6;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ricardo Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(406, 174);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ricardo Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(406, 236);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-589, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(948, 559);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TextBox_Password
            // 
            // 
            // 
            // 
            TextBox_Password.CustomButton.Image = null;
            TextBox_Password.CustomButton.Location = new Point(211, 2);
            TextBox_Password.CustomButton.Name = "";
            TextBox_Password.CustomButton.Size = new Size(23, 23);
            TextBox_Password.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_Password.CustomButton.TabIndex = 1;
            TextBox_Password.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_Password.CustomButton.UseSelectable = true;
            TextBox_Password.CustomButton.Visible = false;
            TextBox_Password.Location = new Point(406, 257);
            TextBox_Password.MaxLength = 32767;
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.ScrollBars = ScrollBars.None;
            TextBox_Password.SelectedText = "";
            TextBox_Password.SelectionLength = 0;
            TextBox_Password.SelectionStart = 0;
            TextBox_Password.ShortcutsEnabled = true;
            TextBox_Password.Size = new Size(237, 28);
            TextBox_Password.TabIndex = 8;
            TextBox_Password.UseSelectable = true;
            TextBox_Password.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Password.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // TextBox_Username
            // 
            // 
            // 
            // 
            TextBox_Username.CustomButton.Image = null;
            TextBox_Username.CustomButton.Location = new Point(211, 2);
            TextBox_Username.CustomButton.Name = "";
            TextBox_Username.CustomButton.Size = new Size(23, 23);
            TextBox_Username.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            TextBox_Username.CustomButton.TabIndex = 1;
            TextBox_Username.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            TextBox_Username.CustomButton.UseSelectable = true;
            TextBox_Username.CustomButton.Visible = false;
            TextBox_Username.Location = new Point(406, 195);
            TextBox_Username.MaxLength = 32767;
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.PasswordChar = '\0';
            TextBox_Username.ScrollBars = ScrollBars.None;
            TextBox_Username.SelectedText = "";
            TextBox_Username.SelectionLength = 0;
            TextBox_Username.SelectionStart = 0;
            TextBox_Username.ShortcutsEnabled = true;
            TextBox_Username.Size = new Size(237, 28);
            TextBox_Username.TabIndex = 8;
            TextBox_Username.UseSelectable = true;
            TextBox_Username.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Username.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            // 
            // Button_Register
            // 
            Button_Register.BackColor = Color.Ivory;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Register.Location = new Point(524, 360);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(119, 33);
            Button_Register.TabIndex = 6;
            Button_Register.Text = "Register";
            Button_Register.UseVisualStyleBackColor = false;
            Button_Register.Click += Button_Register_Click;
            // 
            // CheckBox_ShowPass
            // 
            CheckBox_ShowPass.AutoSize = true;
            CheckBox_ShowPass.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            CheckBox_ShowPass.Location = new Point(406, 291);
            CheckBox_ShowPass.Name = "CheckBox_ShowPass";
            CheckBox_ShowPass.Size = new Size(120, 19);
            CheckBox_ShowPass.TabIndex = 18;
            CheckBox_ShowPass.Text = "Show Password";
            CheckBox_ShowPass.UseSelectable = true;
            CheckBox_ShowPass.CheckedChanged += CheckBox_ShowPass_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(679, 495);
            Controls.Add(CheckBox_ShowPass);
            Controls.Add(TextBox_Username);
            Controls.Add(TextBox_Password);
            Controls.Add(pictureBox1);
            Controls.Add(Button_Register);
            Controls.Add(button_Login);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login User";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button button5;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Password;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Username;
        private Button Button_Register;
        private ReaLTaiizor.Controls.PoisonCheckBox CheckBox_ShowPass;
        private Button button_Login;
    }
}