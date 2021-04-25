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
    public partial class FormHastalar : Form
    {
        public FormHastalar()
        {
            InitializeComponent();
        }
        Baglantilar bgln = new Baglantilar();
        private void FormHastalar_Load(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("Select * From HastaTablo", bgln.baglanti());
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
