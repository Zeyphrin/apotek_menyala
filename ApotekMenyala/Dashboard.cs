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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ApotekMenyala
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            bind_data();
        }
        SqlConnection conn = new SqlConnection("Data Source=LUCIA;Initial Catalog=datapasien;Integrated Security=True");
        DataGridViewRow selectedRow;
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_PasienBaru_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData();
            addData.Show();
            this.Hide();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_PrintPDF_Click(object sender, EventArgs e)
        {
            // Create a Document object
            Document doc = new Document(PageSize.A4);

            try
            {
                // Create SaveFileDialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files (.pdf)|.pdf";
                saveDialog.FileName = "output.pdf"; // default file name

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path chosen by the user
                    string filePath = saveDialog.FileName;

                    // Create a PdfWriter instance to write the document content to the file path
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // Create a PdfPTable with the same number of columns as the DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                    // Add column headers from the DataGridView to the PdfPTable
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        pdfTable.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                    }

                    // Add rows from the DataGridView to the PdfPTable
                    for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                    {
                        for (int column = 0; column < dataGridView1.Columns.Count; column++)
                        {
                            if (dataGridView1[column, rows].Value != null)
                            {
                                pdfTable.AddCell(new Phrase(dataGridView1[column, rows].Value.ToString()));
                            }
                        }
                    }

                    doc.Add(pdfTable);
                    MessageBox.Show("PDF file has been saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchValue = TextBox_Search.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                bind_data();
            }
            else
            {
                try
                {
                    SqlCommand cmdSearch = new SqlCommand("SELECT * FROM datapasien WHERE namapasien LIKE @search", conn);
                    cmdSearch.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmdSearch;

                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Data Not Found !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bind_data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

