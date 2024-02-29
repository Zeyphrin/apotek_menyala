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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
            bind_data();
            dataGridView1.ReadOnly = true;

        }

        SqlConnection conn = new SqlConnection("Data Source=LUCIA;Initial Catalog=datapasien;Integrated Security=True");
        DataGridViewRow selectedRow;

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("select namapasien As namapasien,keluhan As keluhan, jenispasien As jenispasien, namaobat As namaobat, jenisobat As jenisobat, alergipasien As alergipasien, jumlahobat As jumlahobat, waktuminum As waktuminum from datapasien", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11, FontStyle.Bold);

        }

        private void poisonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string selectedTargets = "";
            string jumlahObat = "";
            string jenisPasien = "";
            string alergiPasien = "";

            if (CheckBox_Pagi.Checked)
                selectedTargets += CheckBox_Pagi.Text + ",";
            if (CheckBox_Siang.Checked)
                selectedTargets += CheckBox_Siang.Text + ",";
            if (CheckBox_Malam.Checked)
                selectedTargets += CheckBox_Malam.Text + ",";

            if (RadioButton_1Kali.Checked)
            {
                jumlahObat = RadioButton_1Kali.Text;
            }
            else if (RadioButton_2Kali.Checked)
            {
                jumlahObat = RadioButton_2Kali.Text;
            }
            else if (RadioButton_3Kali.Checked)
            {
                jumlahObat = RadioButton_3Kali.Text;
            }


            if (RadioButton_Subsidi.Checked)
            {
                jenisPasien = RadioButton_Subsidi.Text;
            }
            else if (RadioButton_NonSub.Checked)
            {
                jenisPasien = RadioButton_NonSub.Text;
            }

            if (RadioButton_Alergi.Checked)
            {
                alergiPasien = RadioButton_Alergi.Text;
            }
            else if (RadioButton_TidakAlergi.Checked)
            {
                alergiPasien = RadioButton_TidakAlergi.Text;
            }

            SqlCommand cmd2 = new SqlCommand("Insert into datapasien(namapasien,keluhan,jenispasien,namaobat, jenisobat, alergipasien, jumlahobat, waktuminum)Values(@namapasien,@keluhan,@jenispasien,@namaobat, @jenisobat, @alergipasien, @jumlahobat, @waktuminum)", conn);
            cmd2.Parameters.AddWithValue("namapasien", TextBox_NamaPasien.Text);
            cmd2.Parameters.AddWithValue("keluhan", TextBox_Keluhan.Text);
            cmd2.Parameters.AddWithValue("jenispasien", jenisPasien);
            cmd2.Parameters.AddWithValue("namaobat", TextBox_NamaObat.Text);
            cmd2.Parameters.AddWithValue("jenisobat", ComboBox_JenisObat.Text);
            cmd2.Parameters.AddWithValue("alergipasien", alergiPasien);
            cmd2.Parameters.AddWithValue("jumlahobat", jumlahObat);
            cmd2.Parameters.AddWithValue("waktuminum", selectedTargets);

            conn.Open();

            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            selectedRow = dataGridView1.Rows[index];
            TextBox_NamaPasien.Text = selectedRow.Cells[0].Value.ToString();
            TextBox_Keluhan.Text = selectedRow.Cells[1].Value.ToString();

            // RadioButton
            string radioButtonJenisPasien = selectedRow.Cells[2].Value.ToString();
            if (radioButtonJenisPasien == "Subsidi (BPJS)")
            {
                RadioButton_Subsidi.Checked = true;
            }
            else if (radioButtonJenisPasien == "Non Subsidi")
            {
                RadioButton_NonSub.Checked = true;
            }

            TextBox_NamaObat.Text = selectedRow.Cells[3].Value.ToString();

            // ComboBox
            string selectedValueComboBox = selectedRow.Cells[4].Value.ToString();
            ComboBox_JenisObat.SelectedItem = selectedValueComboBox;

            string radioButtonAlergi = selectedRow.Cells[5].Value.ToString();
            if (radioButtonAlergi == "Alergi")
            {
                RadioButton_Alergi.Checked = true;
            }
            else if (radioButtonAlergi == "Tidak Alergi")
            {
                RadioButton_TidakAlergi.Checked = true;
            }

            string radioButtonJumlahObat = selectedRow.Cells[6].Value.ToString();
            if (radioButtonJumlahObat == "1 Kali")
            {
                RadioButton_1Kali.Checked = true;
            }
            else if (radioButtonJumlahObat == "2 Kali")
            {
                RadioButton_2Kali.Checked = true;
            }
            else if (radioButtonJumlahObat == "3 Kali")
            {
                RadioButton_3Kali.Checked = true;
            }

            string checkBoxValues = selectedRow.Cells[7].Value.ToString(); // Misalkan nilainya "Pagi,Siang,Malam"
            string[] values = checkBoxValues.Split(','); // Pisahkan nilai berdasarkan koma

            foreach (string value in values)
            {
                switch (value)
                {
                    case "Pagi":
                        CheckBox_Pagi.Checked = true;
                        break;
                    case "Siang":
                        CheckBox_Siang.Checked = true;
                        break;
                    case "Malam":
                        CheckBox_Malam.Checked = true;
                        break;
                    default:
                        // Lakukan sesuatu jika nilai tidak sesuai dengan yang diharapkan
                        break;
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string selectedTargets = "";
            string jumlahObat = "";
            string jenisPasien = "";
            string alergiPasien = "";

            if (CheckBox_Pagi.Checked)
                selectedTargets += CheckBox_Pagi.Text + ",";
            if (CheckBox_Siang.Checked)
                selectedTargets += CheckBox_Siang.Text + ",";
            if (CheckBox_Malam.Checked)
                selectedTargets += CheckBox_Malam.Text + ",";

            if (RadioButton_1Kali.Checked)
            {
                jumlahObat = RadioButton_1Kali.Text;
            }
            else if (RadioButton_2Kali.Checked)
            {
                jumlahObat = RadioButton_2Kali.Text;
            }
            else if (RadioButton_3Kali.Checked)
            {
                jumlahObat = RadioButton_3Kali.Text;
            }


            if (RadioButton_Subsidi.Checked)
            {
                jenisPasien = RadioButton_Subsidi.Text;
            }
            else if (RadioButton_NonSub.Checked)
            {
                jenisPasien = RadioButton_NonSub.Text;
            }

            if (RadioButton_Alergi.Checked)
            {
                alergiPasien = RadioButton_Alergi.Text;
            }
            else if (RadioButton_TidakAlergi.Checked)
            {
                alergiPasien = RadioButton_TidakAlergi.Text;
            }

            try
            {
                if (dataGridView1.SelectedRows.Count == 0 || string.IsNullOrWhiteSpace(TextBox_NamaPasien.Text))
                {
                    MessageBox.Show("Choose the Cell you want to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index; // Ambil Index Yang kita Pilih
                string selectedRowNamaPasien = dataGridView1.Rows[selectedRowIndex].Cells["namapasien"].Value.ToString(); // Ambil data "namapasien" dari Index yang sudah kita pilih

                string namaPasienToUpdate = TextBox_NamaPasien.Text; // Ambil "namapasien" di dalam TextBox

                if (namaPasienToUpdate != selectedRowNamaPasien)
                {
                    MessageBox.Show("Nama Pasien Can't be Changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlCommand command = new SqlCommand("UPDATE datapasien SET namapasien = @namapasien, keluhan = @keluhan, jenispasien = @jenispasien, namaobat = @namaobat, jenisobat = @jenisobat, alergipasien = @alergipasien, jumlahobat = @jumlahobat, waktuminum = @waktuminum WHERE namapasien = @namapasien", conn))
                {
                    command.Parameters.AddWithValue("namapasien", TextBox_NamaPasien.Text);
                    command.Parameters.AddWithValue("keluhan", TextBox_Keluhan.Text);
                    command.Parameters.AddWithValue("jenispasien", jenisPasien);
                    command.Parameters.AddWithValue("namaobat", TextBox_NamaObat.Text);
                    command.Parameters.AddWithValue("jenisobat", ComboBox_JenisObat.Text);
                    command.Parameters.AddWithValue("alergipasien", alergiPasien);
                    command.Parameters.AddWithValue("jumlahobat", jumlahObat);
                    command.Parameters.AddWithValue("waktuminum", selectedTargets);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
                bind_data();
                MessageBox.Show("Data Succesfully Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                bind_data(); // This line seems to be redundant. You already called bind_data() inside the try block.
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string selectedNamaPasien = dataGridView1.Rows[selectedRowIndex].Cells["namapasien"].Value.ToString();

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data pasien ini?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=LUCIA;Initial Catalog=datapasien;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmdDelete = new SqlCommand("DELETE FROM datapasien WHERE namapasien = @namapasien", conn);
                            cmdDelete.Parameters.AddWithValue("@namapasien", selectedNamaPasien);
                            cmdDelete.ExecuteNonQuery();

                            bind_data();
                            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox_NamaPasien.Clear();
            TextBox_Keluhan.Clear();
            RadioButton_Subsidi.Checked = false;
            RadioButton_NonSub.Checked = false;
            TextBox_NamaObat.Clear();
            ComboBox_JenisObat.SelectedIndex = -1;
            RadioButton_Alergi.Checked = false;
            RadioButton_TidakAlergi.Checked = false;
            RadioButton_1Kali.Checked = false;
            RadioButton_2Kali.Checked = false;
            RadioButton_3Kali.Checked = false;
            CheckBox_Malam.Checked = false;
            CheckBox_Pagi.Checked = false;
            CheckBox_Siang.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tutup form saat ini (form dashboard)
                this.Close();

                // Tampilkan form login
                Login formLogin = new Login();
                formLogin.Show();
            }
        }
    }
}

