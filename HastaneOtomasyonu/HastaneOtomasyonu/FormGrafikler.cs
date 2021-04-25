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
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select HastaDogumYeri, Count(*) From HastaTablo Group By HastaDogumYeri", bgln.baglanti());
            SqlDataReader verioku = komut1.ExecuteReader();
            while (verioku.Read())
            {
                chart1.Series["DOĞUM YERİ"].Points.AddXY(verioku[0], verioku[1]);
            }
            bgln.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("Select HastaCinsiyet, Count(*) From HastaTablo Group By HastaCinsiyet", bgln.baglanti());
            SqlDataReader verioku2 = komut2.ExecuteReader();
            while(verioku2.Read())
            {
                chart2.Series["CİNSİYET"].Points.AddXY(verioku2[0], verioku2[1]);
            }
            bgln.baglanti().Close();
        }
    }
}
