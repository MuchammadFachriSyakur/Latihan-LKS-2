using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Latihan_LKS_2
{
    public partial class dataArmada : UserControl
    {
        private SqlConnection conn;
        public dataArmada()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=MYBOOKHYPE;Initial Catalog=training;User ID=sa;Password=123;TrustServerCertificate=True");
        }

        private void dataArmada_Load(object sender, EventArgs e)
        {
            ResizeTable();

            this.Resize += new EventHandler(dataArmada_resize);

            showButtons();

            loadDatabaseToTable();
        }

        private void showButtons()
        {
            DataGridViewButtonColumn buttonUbah = new DataGridViewButtonColumn();
            buttonUbah.HeaderText = "Ubah";
            buttonUbah.Name = "buttonUbah";
            buttonUbah.Text = "Ubah";
            buttonUbah.UseColumnTextForButtonValue = true;
            tabelData.Columns.Add(buttonUbah);


            DataGridViewButtonColumn buttonHapus = new DataGridViewButtonColumn();
            buttonHapus.HeaderText = "Hapus";
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Text = "Hapus";
            buttonHapus.UseColumnTextForButtonValue = true;
            tabelData.Columns.Add(buttonHapus);
        }

        private void loadDatabaseToTable()
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM armada";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dataInformasiArmada = new DataTable();
                sda.Fill(dataInformasiArmada);

                tabelData.Rows.Clear();

                foreach (DataRow rows in dataInformasiArmada.Rows)
                {

                    tabelData.Rows.Add(
                        rows["ID"].ToString() ?? "---",
                        rows["nama_mobil"].ToString() ?? "---",
                        rows["jenis_mobil"].ToString() ?? "---",
                        rows["kapasitas"].ToString() ?? "0",
                        rows["jumlah"].ToString() ?? "0"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        private void dataArmada_resize(object? sender, EventArgs e)
        {
            ResizeTable();
        }

        private void ResizeTable()
        {
            tabelData.Width = (int)(this.ClientSize.Width * 0.8);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(tabelData.Rows[e.RowIndex].Cells[0].Value);

                if (tabelData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelData.Columns[e.ColumnIndex].HeaderText == "Ubah")
                {

                    showDataToInput(id);
                }

                if (tabelData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && tabelData.Columns[e.ColumnIndex].HeaderText == "Hapus")
                {
                    var dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini", "Konfimasi", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteData(id);
                    }
                    else
                    {
                        MessageBox.Show("Pilih data yang ingin dihapus");
                    }
                }
            }
        }

        private void deleteData(int id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "DELETE FROM armada WHERE id=@ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus!");
                    loadDatabaseToTable();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void showDataToInput(int ID)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM armada WHERE id = @iD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@iD", ID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    inputID.Text = reader[0].ToString();
                    inputNamaMobil.Text = reader[1].ToString();
                    inputJenisMobil.Text = reader[2].ToString();
                    inputKapasitas.Text = reader[3].ToString();
                    inputJumlah.Text = reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputID.Text))
            {
                try
                {
                    if (!int.TryParse(inputID.Text.Trim(), out int ID))
                    {
                        MessageBox.Show("Id harus berupa angka");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(inputNamaMobil.Text.Trim()))
                    {
                        MessageBox.Show("Nama mobil tidak boleh kosong!");
                        return;
                    }

                    if(string.IsNullOrWhiteSpace(inputJenisMobil.Text.Trim()))
                    {
                        MessageBox.Show("Jenis mobil tidak boleh kosong!");
                        return;
                    }

                    if(!int.TryParse(inputKapasitas.Text.Trim(), out int kapasitas) || kapasitas <= 0)
                    {
                        MessageBox.Show("Kapasitas harus berupa angka positif");
                        return;
                    }

                    if(!int.TryParse(inputJumlah.Text.Trim(), out int jumlah) || jumlah <= 0)
                    {
                        MessageBox.Show("Jumlah harus berupa angka positif!");
                        return;
                    }    

                    if(conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    String query = "UPDATE armada SET nama_mobil = @NamaMobil, jenis_mobil = @JenisMobil, kapasitas = @Kapasitas, jumlah = @Jumlah WHERE id = @ID";

                    using(SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.Add("@ID",SqlDbType.Int).Value = inputID.Text;
                        cmd.Parameters.Add("@NamaMobil",SqlDbType.VarChar).Value = inputNamaMobil.Text.Trim();
                        cmd.Parameters.Add("@JenisMobil",SqlDbType.VarChar).Value = inputJenisMobil.Text.Trim();
                        cmd.Parameters.Add("@Kapasitas",SqlDbType.Int).Value = kapasitas;
                        cmd.Parameters.Add("@Jumlah",SqlDbType.Int).Value = jumlah;

                        int result = cmd.ExecuteNonQuery();

                        if(result > 0)
                        {
                            MessageBox.Show("Berhasil Mengubah data!");

                            loadDatabaseToTable();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data."); 
                        }
                    }
                }
                catch(SqlException ex)
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
            else
            {
                try
                { 

                    if(string.IsNullOrWhiteSpace(inputNamaMobil.Text.Trim()))
                    {
                        MessageBox.Show("Nama mobil tidak boleh kosong!");
                        return;
                    }

                    if(string.IsNullOrWhiteSpace(inputJenisMobil.Text.Trim()))
                    {
                        MessageBox.Show("Jenis mobil tidak boleh kosong!");
                        return;
                    }

                    if(!int.TryParse(inputKapasitas.Text.Trim(), out int kapasitas) || kapasitas <= 0)
                    {
                        MessageBox.Show("Kapasitas harus berupa angka positif!");
                        return;
                    }

                    if (!int.TryParse(inputJumlah.Text.Trim(), out int jumlah) || jumlah <= 0)
                    {
                        MessageBox.Show("Jumlah harus berupa angka positif!");
                        return;
                    }

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    String query = "INSERT INTO armada (nama_mobil,jenis_mobil,kapasitas,jumlah) VALUES (@NamaMobil,@JenisMobil,@Kapasitas,@Jumlah)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@NamaMobil", SqlDbType.VarChar).Value = inputNamaMobil.Text.Trim();
                        cmd.Parameters.Add("@JenisMobil", SqlDbType.VarChar).Value = inputJenisMobil.Text.Trim();
                        cmd.Parameters.Add("@Kapasitas", SqlDbType.Int).Value = kapasitas;
                        cmd.Parameters.Add("@Jumlah", SqlDbType.Int).Value = jumlah;
                    
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data Berhasil ditambahkan!");

                            loadDatabaseToTable();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data.");
                        }
                    }
                    
                }
                catch(SqlException ex)
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

        private void batal_Click(object sender, EventArgs e)
        {
            inputID.Clear();
            inputNamaMobil.Clear();
            inputJenisMobil.SelectedIndex = -1;
            inputJumlah.Clear();
            inputKapasitas.Clear();
        }
    }
}
