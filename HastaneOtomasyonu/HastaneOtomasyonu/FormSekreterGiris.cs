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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select* From SekreterTablo Where SekreterTC = @tc and SekreterSifre = @sifre ", bgln.baglanti());
            komut1.Parameters.AddWithValue("@tc", MskTc.Text);
            komut1.Parameters.AddWithValue("@sifre", TxtSifre.Text);
            SqlDataReader verioku = komut1.ExecuteReader();
            if (verioku.Read())
            {
                FormSekreterEkrani form = new FormSekreterEkrani();
                form.tc = MskTc.Text;
                form.adsoyad = verioku[3].ToString();
                if (tabControl1.SelectedTab == tabPage1) { form.gg = "Gece Sekreteri"; }
                if (tabControl1.SelectedTab == tabPage2) { form.gg = "Gündüz Sekreteri"; }
                form.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı TC Veya Şifre Girişi. Lütfen Tekrar Deneyiniz."); }
            bgln.baglanti().Close();


        }
        
    }
}
