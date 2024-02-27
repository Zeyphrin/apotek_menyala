using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApotekMenyala
{
    public partial class Regi : Form
    {
        string connectionString = "Data Source=LUCIA;Initial Catalog=loginpage;Integrated Security=True;TrustServerCertificate=True";
        public Regi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ShowPass.Checked)
            {
                TextBox_Password.PasswordChar = '\0';
            }
            else
            {
                TextBox_Password.PasswordChar = '*';
            }
        }

        private void TextBox_Password_Click(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            this.Hide();
        }

        private void button_Regsiter_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string password = TextBox_Password.Text;

            // Periksa apakah TextBox Username atau Password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Periksa apakah username sudah ada dalam database
                    string checkUsernameQuery = "SELECT COUNT(*) FROM loginpage WHERE username = @username";
                    SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameQuery, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@username", username);
                    int existingUserCount = (int)checkUsernameCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Username sudah digunakan. Silakan gunakan username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Jika username belum ada, lakukan proses registrasi
                    string insertQuery = "INSERT INTO loginpage (username, password) VALUES (@username, @password)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", password);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registrasi berhasil!");
                        this.Close();
                        Login formLogin = new Login();
                        formLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi gagal!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}