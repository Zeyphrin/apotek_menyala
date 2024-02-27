namespace ApotekMenyala
{
    partial class Regi
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
            TextBox_Username = new ReaLTaiizor.Controls.PoisonTextBox();
            TextBox_Password = new ReaLTaiizor.Controls.PoisonTextBox();
            Button_Login = new Button();
            button_Regsiter = new Button();
            label1 = new Label();
            label2 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            CheckBox_ShowPass = new ReaLTaiizor.Controls.PoisonCheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            TextBox_Username.Location = new Point(32, 183);
            TextBox_Username.MaxLength = 32767;
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.PasswordChar = '\0';
            TextBox_Username.ScrollBars = ScrollBars.None;
            TextBox_Username.SelectedText = "";
            TextBox_Username.SelectionLength = 0;
            TextBox_Username.SelectionStart = 0;
            TextBox_Username.ShortcutsEnabled = true;
            TextBox_Username.Size = new Size(237, 28);
            TextBox_Username.TabIndex = 14;
            TextBox_Username.UseSelectable = true;
            TextBox_Username.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Username.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
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
            TextBox_Password.Location = new Point(32, 245);
            TextBox_Password.MaxLength = 32767;
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.PasswordChar = '*';
            TextBox_Password.ScrollBars = ScrollBars.None;
            TextBox_Password.SelectedText = "";
            TextBox_Password.SelectionLength = 0;
            TextBox_Password.SelectionStart = 0;
            TextBox_Password.ShortcutsEnabled = true;
            TextBox_Password.Size = new Size(237, 28);
            TextBox_Password.TabIndex = 15;
            TextBox_Password.UseSelectable = true;
            TextBox_Password.WaterMarkColor = Color.FromArgb(109, 109, 109);
            TextBox_Password.WaterMarkFont = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            TextBox_Password.Click += TextBox_Password_Click;
            // 
            // Button_Login
            // 
            Button_Login.BackColor = Color.Ivory;
            Button_Login.FlatStyle = FlatStyle.Flat;
            Button_Login.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Login.Location = new Point(32, 331);
            Button_Login.Name = "Button_Login";
            Button_Login.Size = new Size(116, 33);
            Button_Login.TabIndex = 12;
            Button_Login.Text = "Login";
            Button_Login.UseVisualStyleBackColor = false;
            Button_Login.Click += Button_Login_Click;
            // 
            // button_Regsiter
            // 
            button_Regsiter.BackColor = Color.DarkSeaGreen;
            button_Regsiter.FlatStyle = FlatStyle.Flat;
            button_Regsiter.Font = new Font("Ricardo Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Regsiter.Location = new Point(154, 331);
            button_Regsiter.Name = "button_Regsiter";
            button_Regsiter.Size = new Size(115, 33);
            button_Regsiter.TabIndex = 13;
            button_Regsiter.Text = "Register";
            button_Regsiter.UseVisualStyleBackColor = false;
            button_Regsiter.Click += button_Regsiter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ricardo Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 224);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 10;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ricardo Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 162);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Ricardo Medium", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(29, 91);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(233, 42);
            bigLabel1.TabIndex = 9;
            bigLabel1.Text = "Register Page";
            // 
            // CheckBox_ShowPass
            // 
            CheckBox_ShowPass.AutoSize = true;
            CheckBox_ShowPass.FontSize = ReaLTaiizor.Extension.Poison.PoisonCheckBoxSize.Medium;
            CheckBox_ShowPass.Location = new Point(32, 279);
            CheckBox_ShowPass.Name = "CheckBox_ShowPass";
            CheckBox_ShowPass.Size = new Size(120, 19);
            CheckBox_ShowPass.TabIndex = 17;
            CheckBox_ShowPass.Text = "Show Password";
            CheckBox_ShowPass.UseSelectable = true;
            CheckBox_ShowPass.CheckedChanged += CheckBox_ShowPass_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6b4d95a645c0399b46a21963b4200edbf841ea31_s2_n3_y1;
            pictureBox1.Location = new Point(300, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(732, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Regi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 456);
            Controls.Add(pictureBox1);
            Controls.Add(CheckBox_ShowPass);
            Controls.Add(TextBox_Username);
            Controls.Add(TextBox_Password);
            Controls.Add(Button_Login);
            Controls.Add(button_Regsiter);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Regi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Username;
        private ReaLTaiizor.Controls.PoisonTextBox TextBox_Password;
        private Button Button_Login;
        private Button button_Regsiter;
        private Label label1;
        private Label label2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonCheckBox CheckBox_ShowPass;
        private PictureBox pictureBox1;
    }
}