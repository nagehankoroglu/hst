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
    public partial class FormBransDuzenle : Form
    {
        public FormBransDuzenle()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();

        private void FormBransDuzenle_Load(object sender, EventArgs e)
        {
            DataTable tablo1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter("Select* From BransTablo", bgln.baglanti());
            data1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
        }
        BransEkle brn = new BransEkle();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into BransTablo (BransAdı) values (@brans)", bgln.baglanti());
            komut1.Parameters.AddWithValue("@brans", TxtBransAd.Text);
            komut1.ExecuteNonQuery();
            bgln.baglanti().Close();
            brn.MesajYaz();
            DataTable tablo1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter("Select* From BransTablo", bgln.baglanti());
            data1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int hucre = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransAd.Text = dataGridView1.Rows[hucre].Cells[1].Value.ToString();
           
        }
        BransSil brans = new BransSil();
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from BransTablo where BransAdı= @brans", bgln.baglanti());
            komut2.Parameters.AddWithValue("@brans", TxtBransAd.Text);
            komut2.ExecuteNonQuery();
            bgln.baglanti().Close();
            brans.MesajYaz();
            DataTable tablo1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter("Select* From BransTablo", bgln.baglanti());
            data1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;

        }
    }
}
