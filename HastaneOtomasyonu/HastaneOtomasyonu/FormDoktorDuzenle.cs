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
    public partial class FormDoktorDuzenle : Form
    {
        public FormDoktorDuzenle()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        private void FormDoktorDuzenle_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select* From DoktorTablo", bgln.baglanti());
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;

            SqlCommand komut2 = new SqlCommand("Select BransAdı From BransTablo", bgln.baglanti());
            SqlDataReader verioku = komut2.ExecuteReader();
            while (verioku.Read())
            {
                comboBox1.Items.Add(verioku[0]);
            }
            bgln.baglanti().Close();

        }
        DoktorEkle dktr = new DoktorEkle();
        private void BtnEkle_Click(object sender, EventArgs e)
        { 
            SqlCommand komut1 = new SqlCommand("insert into DoktorTablo (DoktorAdSoyad, DoktorBrans) values (@adsoyad, @brans)", bgln.baglanti());
            komut1.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut1.Parameters.AddWithValue("@brans", comboBox1.SelectedItem);
            komut1.ExecuteNonQuery();
            bgln.baglanti().Close();
            dktr.MesajYaz();
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select* From DoktorTablo", bgln.baglanti());
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hucre = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[hucre].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[hucre].Cells[2].Value.ToString();

        }
        DoktorSil dkt = new DoktorSil();
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete From DoktorTablo where DoktorAdSoyad=@adsoyad", bgln.baglanti());
            komut2.Parameters.AddWithValue("@adsoyad", TxtAdSoyad.Text);
            komut2.ExecuteNonQuery();
            bgln.baglanti().Close();
            dkt.MesajYaz();
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select* From DoktorTablo", bgln.baglanti());
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
