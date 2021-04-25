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
    public partial class FormHastaEkrani : Form
    {
        public FormHastaEkrani()
        {
            InitializeComponent();
        }
        public string tc;
        public string adsoyad;
        Baglantilar bgln = new Baglantilar();
        private void FormHastaEkrani_Load(object sender, EventArgs e)
        {
  

            DataTable tablo1 = new DataTable();
            SqlDataAdapter data1 = new SqlDataAdapter("Select * From RandevuTablo where HastaTC="+ tc, bgln.baglanti());
            data1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;

            MskTc.Text = tc;
            TxtAdSoyad.Text = adsoyad;
            SqlCommand komut1 = new SqlCommand("Select BransAdı From BransTablo", bgln.baglanti());
            SqlDataReader verioku = komut1.ExecuteReader();
            while(verioku.Read())
            {
                listBox1.Items.Add(verioku[0]);
            }
            bgln.baglanti().Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select DoktorAdSoyad From DoktorTablo where DoktorBrans= @brans", bgln.baglanti());
            komut2.Parameters.AddWithValue("@brans", listBox1.SelectedItem);
            SqlDataReader verioku2 = komut2.ExecuteReader();
            while(verioku2.Read())
            {
                comboBox1.Items.Add(verioku2[0]);
            }
            bgln.baglanti().Close();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgiGuncelle form = new FormHastaBilgiGuncelle();
            form.tc = MskTc.Text;
            form.Show();
        }
        public string secilen;
        Randevu rnd = new Randevu();
        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { secilen = checkBox1.Text; }
            if (checkBox2.Checked == true) { secilen = secilen + " " +  checkBox2.Text; }
            if (checkBox3.Checked == true) { secilen = secilen + " " + checkBox3.Text; }
            if (checkBox4.Checked == true) { secilen = secilen + " " + checkBox4.Text; }
            if (checkBox5.Checked == true) { secilen = secilen + " " + checkBox5.Text; }
            if (checkBox6.Checked == true) { secilen = secilen + " " + checkBox6.Text; }

            SqlCommand komut4 = new SqlCommand("Select * From RandevuTablo where RandevuDoktor = @doktor and RandevuTarih = @tarih and RandevuSaat = @saat", bgln.baglanti());
            komut4.Parameters.AddWithValue("@doktor", comboBox1.SelectedItem);
            komut4.Parameters.AddWithValue("@tarih", MskTarih.Text);
            komut4.Parameters.AddWithValue("@saat", MskSaat.Text);
            SqlDataReader verioku3 = komut4.ExecuteReader();
            if (verioku3.Read()) { MessageBox.Show("Bu randevu alınmıştır. Lütfen başka bir randevu seçiniz."); }
            else
            {
                SqlCommand komut3 = new SqlCommand("insert into RandevuTablo (HastaTC,RandevuBrans, RandevuDoktor, RandevuSikayet, RandevuTarih,RandevuSaat) values (@tc,@brans,@doktor,@sikayet,@tarih,@saat)", bgln.baglanti());
                komut3.Parameters.AddWithValue("@tc", MskTc.Text);
                komut3.Parameters.AddWithValue("@brans", listBox1.SelectedItem);
                komut3.Parameters.AddWithValue("@doktor", comboBox1.SelectedItem);
                komut3.Parameters.AddWithValue("@sikayet", secilen);
                komut3.Parameters.AddWithValue("@tarih", MskTarih.Text);
                komut3.Parameters.AddWithValue("@saat", MskSaat.Text);
                komut3.ExecuteNonQuery();
                bgln.baglanti().Close();
                rnd.MesajYaz();
                DataTable tablo1 = new DataTable();
                SqlDataAdapter data1 = new SqlDataAdapter("Select * From RandevuTablo where HastaTC=" + tc, bgln.baglanti());
                data1.Fill(tablo1);
                dataGridView1.DataSource = tablo1;
            }


        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
