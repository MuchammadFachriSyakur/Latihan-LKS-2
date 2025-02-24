using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latihan_LKS_2
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=MYBOOKHYPE;Initial Catalog=training;User ID=sa;Password=123;TrustServerCertificate=True");
            centeringPanel(guna2Panel1);

            this.Resize += Form1_Resize;
            inputUsername.KeyDown += Username_KeyDown;
            inputPassword.KeyDown += Password_KeyDown;
        }



        private void Form1_Resize(object? sender, EventArgs e)
        {
            centeringPanel(guna2Panel1);
        }

        private void centeringPanel(Panel panel)
        {
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = inputUsername.Text;
                string password = inputPassword.Text;

                String querry = "SELECT * FROM akun WHERE username = '" + inputUsername.Text + "' AND password='" + inputPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(querry, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataAkun = new DataTable();
                sda.Fill(dataAkun);

                if (dataAkun.Rows.Count > 0)
                {
                    MessageBox.Show("Login Berhasil");

                    Dashboard halamanDashboard = new Dashboard();

                    halamanDashboard.Dock = DockStyle.Fill;

                    this.Hide();

                    halamanDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                inputPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if(e.KeyCode == Keys.Down)
            {
                inputPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if(e.KeyCode ==  Keys.Up)
            {
                inputUsername.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void LabelHead_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            customerPage halamanCustomer = new customerPage();
            halamanCustomer.Dock = DockStyle.Fill;
            this.Hide();
            halamanCustomer.Show();
        }
    }
}
