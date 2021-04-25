using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HastaneOtomasyonu
{
    class Baglantilar
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-6NSTRIDS;Initial Catalog=HastaneOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
    abstract class Soyut
    {
        abstract public void SifreYaz();
    }
    class Tureyen : Soyut
    {
        public override void SifreYaz()
        {
            MessageBox.Show("Lütfen belirlediğiniz şifre ile giriş yapınız.");
        }
        private string soyad;

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
    }
    class Mesaj
    {
        public virtual void MesajYaz()
        { 
        }
    }
    class HastaKaydetme : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Kaydınız Başarıyla Tamamlanmıştır.");
        }
    }
    class HastaGuncelleme : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.");
        }
    }
    class Randevu : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Randevu Kaydı Başarıyla Oluşturuldu.");
        }
    }
    class DoktorEkle : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Doktor Kaydı Başarıyla Eklendi.");
        }
    }
     class DoktorSil : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Doktor Kaydı Başarıyla Silindi");
        }
    }
    class BransEkle : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Branş Kaydı Başarıyla Eklendi.");
        }
    }
    class BransSil : Mesaj
    {
        public override void MesajYaz()
        {
            MessageBox.Show("Branş Kaydı Başarıyla Silindi.");
        }
    }
}
