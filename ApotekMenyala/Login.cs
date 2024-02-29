using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApotekMenyala
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Regi formRegister = new Regi();
            formRegister.Show();
            this.Hide();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LUCIA;Initial Catalog=loginpage;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                // Periksa apakah username ada dalam database
                string checkUserQuery = "SELECT COUNT(*) FROM loginpage WHERE username=@username";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, con);
                checkUserCmd.Parameters.AddWithValue("@username", TextBox_Username.Text);
                int userCount = (int)checkUserCmd.ExecuteScalar();

                if (userCount == 0)
                {
                    MessageBox.Show("Username tidak ditemukan. Silakan daftar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Redirect ke halaman registrasi
                    this.Hide();
                    Regi formRegister = new Regi();
                    formRegister.Show();
                    return;
                }

                // Jika username ada, lanjutkan pengecekan password
                string query = "SELECT COUNT(*) FROM loginpage WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TextBox_Username.Text);
                cmd.Parameters.AddWithValue("@password", TextBox_Password.Text);
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Login Sukses!");
                    this.Hide();
                    Dashboard formDashboard = new Dashboard();
                    formDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }

        }

        private void poisonButton_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup halaman?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Memeriksa apakah pengguna menekan tombol Yes pada pesan peringatan
            if (result == DialogResult.Yes)
            {
                // Menutup halaman
                Application.Exit();
            }
        }
    }
}
