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
    public partial class dataJadwal : UserControl
    {
        private SqlConnection conn;
        public dataJadwal()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=MYBOOKHYPE;Initial Catalog=training;User ID=sa;Password=123;TrustServerCertificate=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabelDataJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tabelDataJadwal.Rows[e.RowIndex].Cells[0].Value);

                if (tabelDataJadwal.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelDataJadwal.Columns[e.ColumnIndex].HeaderText == "Ubah")
                {
                    showDataToInput(id);
                }

                if (tabelDataJadwal.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelDataJadwal.Columns[e.ColumnIndex].HeaderText == "Hapus")
                {
                    var dialogBox = MessageBox.Show("Apakah anda yakin menghapus data ini", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(dialogBox == DialogResult.Yes)
                    {
                        deleteData(id);
                    }
                }
            }
        }

        private void showDataToInput(int id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String query = "SELECT * FROM jadwal WHERE id=@ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Data ditemukan");
                        inputID.Text = reader["id"].ToString();

                        string idArmada = reader["id_armada"].ToString();

                        if (inputNamaMobil.Items.Cast<DataRowView>().Any(item => item["id"].ToString() == idArmada))
                        {
                            inputNamaMobil.SelectedValue = idArmada;
                        }

                        inputAsal.SelectedItem = reader["asal"].ToString();
                        inputTujuan.SelectedItem = reader["tujuan"].ToString();
                        inputTanggal.Value = Convert.ToDateTime(reader["tanggal"]);
                        inputJam.Value = DateTime.Today.Add((TimeSpan)reader["jam"]);
                        inputHargaTiket.Text = reader["harga_tiket"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan");
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
        private void deleteData(int id)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String query = "DELETE FROM jadwal WHERE id=@ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    int result = cmd.ExecuteNonQuery();

                    if(result > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus.");
                        loadDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Data Gagal dihapus!");
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

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataJadwal_Load(object sender, EventArgs e)
        {
            loadDatabase();
            loadNamaMobilToInput();
            showButtons();
        }

        private void showButtons()
        {
            DataGridViewButtonColumn buttonUbah = new DataGridViewButtonColumn();
            buttonUbah.Text = "Ubah";
            buttonUbah.Name = "buttonUbah";
            buttonUbah.HeaderText = "Ubah";
            buttonUbah.UseColumnTextForButtonValue = true;
            tabelDataJadwal.Columns.Add(buttonUbah);

            DataGridViewButtonColumn buttonHapus = new DataGridViewButtonColumn();
            buttonHapus.Text = "Hapus";
            buttonHapus.Name = "buttonHapus";
            buttonHapus.HeaderText = "Hapus";
            buttonHapus.UseColumnTextForButtonValue = true;
            tabelDataJadwal.Columns.Add(buttonHapus);
        }

        private void loadDatabase()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM jadwal";

                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    tabelDataJadwal.Rows.Clear();

                    foreach(DataRow rows in dt.Rows)
                    {
                        tabelDataJadwal.Rows.Add(
                          rows["id"].ToString() ?? "0",
                          rows["id_armada"].ToString() ?? "0",
                          rows["asal"].ToString() ?? "---",
                          rows["tujuan"].ToString () ?? "",
                          rows["tanggal"].ToString() ?? "",
                          rows["jam"].ToString() ?? "",
                          rows["harga_tiket"].ToString() ?? ""
                        );
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch(Exception ex)
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

        private void loadNamaMobilToInput()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String query = "SELECT id,nama_mobil FROM armada";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader sda = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sda);

                        inputNamaMobil.DataSource = dt;
                        inputNamaMobil.DisplayMember = "nama_mobil";
                        inputNamaMobil.ValueMember = "id";
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Sql Error: {ex.Message}");
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

        private void buttonBatal_Click_1(object sender, EventArgs e)
        {
            inputID.Clear();
            inputNamaMobil.SelectedIndex = 0;
            inputAsal.SelectedIndex = 0;
            inputTujuan.SelectedIndex = 0;
            inputTanggal.Value = DateTime.Now;
            inputJam.Value = DateTime.Now;
            inputHargaTiket.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inputID.Text))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    if (string.IsNullOrWhiteSpace(inputNamaMobil.Text.Trim()))
                    {
                        MessageBox.Show("Nama Mobil harus diisi!");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(inputAsal.Text.Trim()))
                    {
                        MessageBox.Show("Asal kota harus diisi!");
                        return;
                    }

                    if (inputTanggal.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Tanggal tidak boleh lebih kecil dari hari ini!");
                        return;
                    }

                    TimeSpan waktuSekarang = DateTime.Now.TimeOfDay;
                    TimeSpan waktuInput = inputJam.Value.TimeOfDay;

                    if (waktuInput < waktuSekarang && inputJam.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Jam tidak boleh lebih kecil dari waktu saat ini untuk tanggal hari ini!");
                        return;
                    }

                    if (!int.TryParse(inputHargaTiket.Text.Trim(), out int hargaTiket) || hargaTiket <= 0)
                    {
                        MessageBox.Show("Harga tiket harus berupa angka positif!");
                        return;
                    }

                    if (string.Equals(inputAsal.Text.Trim(), inputTujuan.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Asal dan tujuan tidak boleh sama!");
                        return;
                    }

                    int idMobil = Convert.ToInt32(inputNamaMobil.SelectedValue);

                    if (idMobil <= 0)
                    {
                        MessageBox.Show("Id tidak valid!");
                        return;
                    }

                    String query = "INSERT INTO jadwal (id_armada,asal,tujuan,tanggal,jam,harga_tiket) OUTPUT INSERTED.id VALUES (@IDMobil,@Asal,@Tujuan,@Tanggal,@Jam,@HargaTiket)";

                    int lastInsertID = 0;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@IDMobil", SqlDbType.Int).Value = idMobil;
                        cmd.Parameters.Add("@Asal", SqlDbType.VarChar, 75).Value = inputAsal.Text.Trim();
                        cmd.Parameters.Add("@Tujuan", SqlDbType.VarChar, 75).Value = inputTujuan.Text.Trim();
                        cmd.Parameters.Add("@Tanggal", SqlDbType.Date).Value = inputTanggal.Value.Date;
                        cmd.Parameters.Add("@Jam", SqlDbType.Time).Value = inputJam.Value.TimeOfDay;
                        cmd.Parameters.Add("@HargaTiket", SqlDbType.Int).Value = hargaTiket;

                        object resultID = cmd.ExecuteScalar();
                        lastInsertID = (resultID == DBNull.Value || resultID == null) ? 0 : Convert.ToInt32(resultID);
                    }

                    if (lastInsertID > 0)
                    {
                        String insertStatusQuery = "INSERT INTO status_perjalanan (id_jadwal,status_perjalanan) VALUES (@ID,@Status)";

                        using (SqlCommand cmdStatus = new SqlCommand(insertStatusQuery, conn))
                        {
                            cmdStatus.Parameters.Add("@ID", SqlDbType.Int).Value = lastInsertID;
                            cmdStatus.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = "Menunggu"; ;

                            int resultStatus = cmdStatus.ExecuteNonQuery();

                            if (resultStatus > 0)
                            {
                                MessageBox.Show("Status perjalanan berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambahkan status perjalanan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            loadDatabase();
                        }
                    }

                    if (lastInsertID < 0)
                    {
                        MessageBox.Show("Gagal");
                        loadDatabase();
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Sql Error: {ex.Message}");
                }
                catch(Exception ex)
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
            else
            {
                try
                {
                    int id = Convert.ToInt32(inputID.Text.Trim());
                    int idMobil = Convert.ToInt32(inputNamaMobil.SelectedValue);

                    if (string.IsNullOrWhiteSpace(inputID.Text.Trim()))
                    {
                        MessageBox.Show("Input ID harus di ada!");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(inputNamaMobil.Text.Trim()))
                    {
                        MessageBox.Show("Nama mobil harus di ada!");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(inputAsal.Text.Trim()))
                    {
                        MessageBox.Show("Asal daerah harus diisi!");
                        return;
                    }

                    if (inputTanggal.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Tanggal tidak boleh dimasa lalu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    TimeSpan waktuSekarang = DateTime.Now.TimeOfDay;
                    TimeSpan waktuInput = inputJam.Value.TimeOfDay;

                    if (inputTanggal.Value.Date == DateTime.Now.Date && waktuInput < waktuSekarang)
                    {
                        MessageBox.Show("Jam keberangkatan tidak boleh lebih kecil dari waktu saat ini untuk hari ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(inputHargaTiket.Text.Trim(), out int hargaTiket) || hargaTiket <= 0)
                    {
                        MessageBox.Show("Harga Tiket harus berupa angka positif!");
                        return;
                    }

                    if (string.Equals(inputAsal.Text.Trim(), inputTujuan.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Asal dan tujuan tidak boleh sama!");
                        return;
                    }

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    String query = "UPDATE jadwal SET id_armada=@idArmada, asal=@Asal, tujuan=@Tujuan, tanggal=@Tanggal, jam=@Jam, harga_tiket=@HargaTiket WHERE id=@ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@idArmada", SqlDbType.Int).Value = idMobil;
                        cmd.Parameters.Add("@Asal", SqlDbType.VarChar, 75).Value = inputAsal.Text.Trim();
                        cmd.Parameters.Add("@Tujuan", SqlDbType.VarChar, 75).Value = inputTujuan.Text.Trim();
                        cmd.Parameters.Add("@Tanggal", SqlDbType.Date).Value = inputTanggal.Value.Date;
                        cmd.Parameters.Add("@Jam", SqlDbType.Time).Value = inputJam.Value.TimeOfDay;
                        cmd.Parameters.Add("@HargaTiket", SqlDbType.Int).Value = hargaTiket;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                        int result = cmd.ExecuteNonQuery();

                        if(result > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            loadDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diperbarui!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch(Exception ex)
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
}
