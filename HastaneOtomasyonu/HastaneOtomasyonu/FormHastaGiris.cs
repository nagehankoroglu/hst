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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            FormHastaKayıt form = new FormHastaKayıt();
            form.Show();
        }
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From HastaTablo Where HastaTC = @tc and HastaSifre = @sifre", bgln.baglanti());
            komut1.Parameters.AddWithValue("@tc", MskTc.Text);
            komut1.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            SqlDataReader verioku = komut1.ExecuteReader();
            if (verioku.Read())
            {
                FormHastaEkrani form = new FormHastaEkrani();
                form.tc = MskTc.Text;
                form.adsoyad = verioku[3] + " " + verioku[4];
                form.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı TC Veya Şifre Girişi. Lütfen Tekrar Deneyiniz."); }
            bgln.baglanti().Close();
        }
    }
}
