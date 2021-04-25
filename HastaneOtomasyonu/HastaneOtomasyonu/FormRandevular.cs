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
    public partial class FormRandevular : Form
    {
        public FormRandevular()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        private void FormRandevular_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select * From RandevuTablo", bgln.baglanti());
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
