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
    public partial class FormHastaKayıt : Form
    {
        public FormHastaKayıt()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        HastaKaydetme hst = new HastaKaydetme();
        Tureyen nesne = new Tureyen();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            nesne.SOYAD = TxtSoyad.Text;
            TxtSoyad.Text = nesne.SOYAD;
            SqlCommand komut1 = new SqlCommand("insert into HastaTablo (HastaTC,HastaSifre,HastaAdı,HastaSoyadı, HastaDogumTarihi,HastaDogumYeri, HastaTelefon,HastaCinsiyet) values (@tc,@sifre,@ad,@soyad,@dogumtarihi,@dogumyeri,@telefon,@cinsiyet)", bgln.baglanti());
            komut1.Parameters.AddWithValue("@tc", MskTc.Text);
            komut1.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            komut1.Parameters.AddWithValue("@ad", TxtAd.Text);
            komut1.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@dogumtarihi", MskDogumTarihi.Text);
            komut1.Parameters.AddWithValue("@dogumyeri", comboBox1.Text);
            komut1.Parameters.AddWithValue("@telefon", MskTelefon.Text);
            if (radioButton1.Checked == true) { label8.Text = "Kadın"; }
            if (radioButton2.Checked == true) { label8.Text = "Erkek"; }
            komut1.Parameters.AddWithValue("@cinsiyet", label8.Text);
            komut1.ExecuteNonQuery();
            bgln.baglanti().Close();
            hst.MesajYaz();
            nesne.SifreYaz();
            
        }
    }
}

