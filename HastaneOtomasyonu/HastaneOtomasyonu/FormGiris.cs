using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FormHastaGiris form = new FormHastaGiris();
            form.Show();
            this.Hide();
        }
        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FormSekreterGiris form = new FormSekreterGiris();
            form.Show();
            this.Hide();
        }
    }
}
