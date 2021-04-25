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
    public partial class FormHastaBilgiGuncelle : Form
    {
        public FormHastaBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string tc;
        Baglantilar bgln = new Baglantilar();
        HastaGuncelleme hst = new HastaGuncelleme();
        private void FormHastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            TxtTc.Text = tc;
            SqlCommand komut1 = new SqlCommand("Select HastaSifre,HastaAdı, HastaSoyadı, HastaTelefon from HastaTablo where HastaTC= @tc", bgln.baglanti());
            komut1.Parameters.AddWithValue("@tc", TxtTc.Text);
            SqlDataReader verioku = komut1.ExecuteReader();
            while ( verioku.Read())
            {
                TxtSifre.Text = verioku[0].ToString();
                TxtAd.Text = verioku[1].ToString();
                TxtSoyad.Text = verioku[2].ToString();
                MskTelefon.Text = verioku[3].ToString();
            }
            bgln.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update HastaTablo set HastaSifre=@sifre, HastaAdı=@ad, HastaSoyadı=@soyad, HastaTelefon=@telefon Where HastaTC=@tc", bgln.baglanti());
            komut2.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@ad", TxtAd.Text);
            komut2.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", MskTelefon.Text);
            komut2.Parameters.AddWithValue("@tc", TxtTc.Text);
            komut2.ExecuteNonQuery();
            bgln.baglanti().Close();
            hst.MesajYaz();
            this.Hide();


        }
    }
}
