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
            label1 = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 163);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Login Page";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(132, 192);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(154, 23);
            textBox_Username.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(132, 238);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(154, 23);
            textBox_Password.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login User";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
    }
}