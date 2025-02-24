using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Latihan_LKS_2
{
    public partial class cariPerjalanan : UserControl
    {
        private SqlConnection conn;
        public cariPerjalanan()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=MYBOOKHYPE;Initial Catalog=training;User ID=sa;Password=123;TrustServerCertificate=True");
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cariPerjalanan_Load(object sender, EventArgs e)
        {
            loadDatabase();
            showEditButtons();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tabelDataJadwal.Rows[e.RowIndex].Cells[0].Value);

                if (tabelDataJadwal.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelDataJadwal.Columns[e.ColumnIndex].HeaderText == "Aksi")
                {
                    formStatus.Visible = true;
                    inputID.Text = id.ToString();
                }
            }
        }

        private void showEditButtons()
        {
            DataGridViewButtonColumn buttonUbah = new DataGridViewButtonColumn();
            buttonUbah.Text = "Ubah";
            buttonUbah.Name = "buttonUbah";
            buttonUbah.HeaderText = "Aksi";
            buttonUbah.UseColumnTextForButtonValue = true;
            tabelDataJadwal.Columns.Add(buttonUbah);
        }

        private void loadDatabase()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String query = "SELECT sp.id, sp.id_jadwal,sp.status_perjalanan, j.tanggal,j.jam FROM status_perjalanan sp JOIN jadwal j ON sp.id_jadwal = j.id";

                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    tabelDataJadwal.Rows.Clear();

                    foreach (DataRow rows in dt.Rows)
                    {
                        tabelDataJadwal.Rows.Add(
                          rows["id"].ToString() ?? "---",
                          rows["tanggal"].ToString() ?? "---",
                          rows["jam"].ToString() ?? "---",
                          rows["status_perjalanan"].ToString() ?? "Menunggu"
                        );
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = inputID.Text.Trim();
                string status = comboBoxStatus.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Input ID tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Anda harus memilih status", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxStatus.Focus();
                    return;
                }

                if (!int.TryParse(id, out int ID) || ID <= 0)
                {
                    MessageBox.Show("Input ID harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputID.Focus();
                    return;
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String query = "UPDATE status_perjalanan SET status_perjalanan=@status WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@status", SqlDbType.VarChar, 50).Value = status;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}");
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}
