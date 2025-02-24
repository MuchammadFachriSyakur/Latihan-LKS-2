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
    public partial class customerPage : Form
    {
        SqlConnection conn;
        public customerPage()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=MYBOOKHYPE;Initial Catalog=training;User ID=sa;Password=123;TrustServerCertificate=True");
        }

        private void headerText_Click(object sender, EventArgs e)
        {

        }

        private void labelAndInputBerangkat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonCariJadwal_Click_1(object sender, EventArgs e)
        {
            if (string.Equals(inputTujuan.Text.Trim(), inputBerangkat.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Tempat keberangkatan tidak boleh sama dengan tujuan keberangkatan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inputTanggal.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Tanggal tidak boleh kecil dari hari ini", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            getDataAndLoadToTable();

            addButtonBuyTiketToRows();
        }

        private void listJadwalContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tabelData.Rows[e.RowIndex].Cells[0].Value);

                if (tabelData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelData.Columns[e.ColumnIndex].HeaderText == "Aksi")
                {
                    home.Visible = false;
                    listJadwalContent.Visible = false;
                    tiketPage.Visible = true;

                    tiketPage.Dock = DockStyle.Fill;

                    getDataTransaksiHeader(id);
                }
            }

        }

        private void getDataTransaksiHeader(int id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT id,tanggal,jam,harga_tiket FROM jadwal WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idReader = (int)reader["id"];
                            DateTime tanggal = (DateTime)reader["tanggal"];
                            TimeSpan jam = (TimeSpan)reader["jam"];
                            decimal harga_tiket = (int)reader["harga_tiket"];

                            inputIdTransaksi.Text = idReader.ToString();
                            infoTanggalTransaksi.Text = tanggal.ToString();
                            infoJamTransaksi.Text = jam.ToString();
                            infoTotalPembayaran.Text = harga_tiket.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void customerPage_Load(object sender, EventArgs e)
        {

        }

        private void addButtonBuyTiketToRows()
        {
            if (tabelData.Columns["btnTiket"] == null)
            {
                if (tabelData.Rows.Count > 0)
                {
                    DataGridViewButtonColumn buttonBeliTiket = new DataGridViewButtonColumn();
                    buttonBeliTiket.Name = "btnTiket";
                    buttonBeliTiket.Text = "Beli Tiket";
                    buttonBeliTiket.HeaderText = "Aksi";
                    buttonBeliTiket.UseColumnTextForButtonValue = true;
                    tabelData.Columns.Add(buttonBeliTiket);
                }
                else
                {
                    return;
                }
            }
        }

        private void getDataAndLoadToTable()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                String asal = inputBerangkat.SelectedItem.ToString();
                String tujuan = inputTujuan.SelectedItem.ToString();
                DateTime tanggal = inputTanggal.Value.Date;

                string query = @"SELECT ja.id, ja.asal, ja.tujuan, ja.tanggal, ja.jam, ja.harga_tiket, ar.nama_mobil 
                     FROM jadwal ja 
                     JOIN armada ar ON ja.id_armada = ar.id
                     WHERE ja.asal = @asal AND ja.tujuan = @tujuan AND CONVERT(date, ja.tanggal) = @tanggal";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@asal", SqlDbType.VarChar).Value = asal;
                    cmd.Parameters.Add("@tujuan", SqlDbType.VarChar).Value = tujuan;
                    cmd.Parameters.Add("@tanggal", SqlDbType.Date).Value = tanggal;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable jadwalArmada = new DataTable();
                        sda.Fill(jadwalArmada);

                        if (jadwalArmada.Rows.Count == 0)
                        {
                            MessageBox.Show("Tidak ada jadwal yang ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        home.Visible = false;
                        listJadwalContent.Visible = true;
                        listJadwalContent.Dock = DockStyle.Fill;
                        tabelData.Rows.Clear();
                        foreach (DataRow rows in jadwalArmada.Rows)
                        {
                            tabelData.Rows.Add(
                                rows["id"].ToString() ?? "---",
                                rows["nama_mobil"].ToString() ?? "---",
                                rows["asal"].ToString() ?? "---",
                                rows["tujuan"].ToString() ?? "---",
                                rows["tanggal"].ToString() ?? "---",
                                rows["jam"].ToString() ?? "---"
                            );
                        }
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

        private void buttonBackListJadwal_Click(object sender, EventArgs e)
        {
            home.Visible = true;
            listJadwalContent.Visible = false;
            tabelData.Rows.Clear();

            if (tabelData.Columns["btnTiket"] != null)
            {
                tabelData.Columns.Remove("btnTiket");
            }
        }

        private void buttonBackPembelianTiket_Click(object sender, EventArgs e)
        {
            clearInput();

            tiketPage.Visible = false;
            listJadwalContent.Visible = true;
            listJadwalContent.Dock = DockStyle.Fill;
        }

        private void clearInput()
        {
            inputIdTransaksi.Clear();
            inputNoKtp.Clear();
            inputNamaLengkap.Clear();
            inputNomorHp.Clear();
            inputJumlahPenumpang.Value = 0;
            infoTanggalTransaksi.Text = "00-00-0000";
            infoJamTransaksi.Text = "00:00";
            infoTotalPembayaran.Text = "000";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputIdTransaksi.Text.Trim()))
                {
                    MessageBox.Show("Id Tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(inputIdTransaksi.Text.Trim(), out _))
                {
                    MessageBox.Show("Id harus angka positif", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(inputNoKtp.Text.Trim(), out long nomorKtp) || inputNoKtp.Text.Trim().Length != 16 || nomorKtp < 0)
                {
                    MessageBox.Show("Nomor Ktp harus berisi 16 digit angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(inputNomorHp.Text.Trim(), out long nomorHp))
                {
                    MessageBox.Show("Nomor Hp harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nomorHp < 0)
                {
                    MessageBox.Show("Nomor hp harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(inputNamaLengkap.Text.Trim()))
                {
                    MessageBox.Show("Nama lengkap harus di isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inputNomorHp.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Nomor hp harus lebih dari 10 angka tidak lebih dari 13!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inputNomorHp.Text.Trim().Length > 13)
                {
                    MessageBox.Show("Nomor hp tidak boleh melebihi 13 angka dan tidak kurang dari 10!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(infoTanggalTransaksi.Text.Trim(), out DateTime tanggalValid))
                {
                    MessageBox.Show("Format tanggal tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tanggalValid.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Tanggal tidak boleh lebih kecil dari hari ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TimeSpan.TryParse(infoJamTransaksi.Text.Trim(), out TimeSpan jamValid))
                {
                    MessageBox.Show("Format jam tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inputJumlahPenumpang.Value < 1)
                {
                    MessageBox.Show("Jumlah penumpang tidak boleh kurang dari 1!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlTransaction transaction = conn.BeginTransaction();

                String queryHeader = "INSERT INTO transaksi_header (id_jadwal,tanggal_transaksi,jumlah_tiket,total) VALUES (@idJadwal,@tanggalTransaksi,@jumlahTiket,@total); " + "SELECT SCOPE_IDENTITY();";
                SqlCommand cmdHeader = new SqlCommand(queryHeader, conn, transaction);
                cmdHeader.Parameters.Add("@idJadwal", SqlDbType.Int).Value = Convert.ToInt32(inputIdTransaksi.Text.Trim());
                cmdHeader.Parameters.Add("@tanggalTransaksi", SqlDbType.DateTime).Value = tanggalValid;
                cmdHeader.Parameters.Add("@jumlahTiket", SqlDbType.Int).Value = Convert.ToInt32(inputJumlahPenumpang.Value);
                cmdHeader.Parameters.Add("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(infoTotalPembayaran.Text.Trim());
                cmdHeader.Parameters["@total"].Precision = 18;
                cmdHeader.Parameters["@total"].Scale = 2;

                int idTransaksi = Convert.ToInt32(cmdHeader.ExecuteScalar());

                String queryDetail = "INSERT INTO transaksi_detail (id_transaksi, no_ktp, nama_lengkap, no_hp) VALUES (@idTransaksi,@noKtp,@namaLengkap,@noHp)";
                SqlCommand cmdDetail = new SqlCommand(queryDetail, conn, transaction);
                cmdDetail.Parameters.Add("idTransaksi", SqlDbType.Int).Value = idTransaksi;
                cmdDetail.Parameters.Add("noKtp", SqlDbType.VarChar, 16).Value = nomorKtp.ToString();
                cmdDetail.Parameters.Add("namaLengkap", SqlDbType.VarChar).Value = inputNamaLengkap.Text.Trim();
                cmdDetail.Parameters.Add("noHp", SqlDbType.VarChar, 13).Value = inputNomorHp.Text.Trim();

                cmdDetail.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Pembelian berhasil.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Sql Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
