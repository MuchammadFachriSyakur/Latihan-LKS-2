using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_LKS_2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            pageContent.Controls.Clear();

            dataArmada halaman1 = new dataArmada();

            halaman1.Dock = DockStyle.Fill;

            pageContent.Controls.Add(halaman1);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonDataArmada_Click(object sender, EventArgs e)
        {
            pageContent.Controls.Clear();

            dataArmada halaman1 = new dataArmada();

            halaman1.Dock = DockStyle.Fill;

            pageContent.Controls.Add(halaman1);
        }

        private void buttonDataJadwal_Click(object sender, EventArgs e)
        {

        }

        private void buttonCariPerjalanan_Click(object sender, EventArgs e)
        {

        }

        private void buttonDataJadwal_Click_1(object sender, EventArgs e)
        {
            pageContent.Controls.Clear();

            dataJadwal halaman2 = new dataJadwal();

            halaman2.Dock = DockStyle.Fill;

            pageContent.Controls.Add(halaman2);
        }

        private void buttonCariPerjalanan_Click_1(object sender, EventArgs e)
        {
            pageContent.Controls.Clear();

            cariPerjalanan halamn3 = new cariPerjalanan();

            halamn3.Dock = DockStyle.Fill;

            pageContent.Controls.Add(halamn3);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form1 halamanLogin = new Form1();
            halamanLogin.Dock = DockStyle.Fill;
            this.Hide();
            halamanLogin.Show();
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {

        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pageContent_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
