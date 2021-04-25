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

namespace HastaneOtomasyonu
{
    public partial class FormSekreterEkrani : Form
    {
        public FormSekreterEkrani()
        {
            InitializeComponent();
        }
        public string gg;
        Baglantilar bgln = new Baglantilar();
        public string tc;
        public string adsoyad;
        private void FormSekreterEkrani_Load(object sender, EventArgs e)
        {
            label3.Text = gg;
            MskTc.Text = tc;
            TxtAdSoyad.Text = adsoyad;

            DataTable tablo1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter("Select* From BransTablo", bgln.baglanti());
            data1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;

            DataTable tablo2 = new DataTable();
            SqlDataAdapter data2 = new SqlDataAdapter("Select* From DoktorTablo", bgln.baglanti());
            data2.Fill(tablo2);
            dataGridView2.DataSource = tablo2;


        }

        private void BtnDoktorDuzenle_Click(object sender, EventArgs e)
        {
            FormDoktorDuzenle form = new FormDoktorDuzenle();
            form.Show();
        }

        private void BtnBransDuzenle_Click(object sender, EventArgs e)
        {
            FormBransDuzenle form = new FormBransDuzenle();
            form.Show();
        }

        private void BtnRandevular_Click(object sender, EventArgs e)
        {
            FormRandevular form = new FormRandevular();
            form.Show();
        }

        private void BtnHastalar_Click(object sender, EventArgs e)
        {
            FormHastalar form = new FormHastalar();
            form.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGrafikler form = new FormGrafikler();
            form.Show();
        }
    }
}
