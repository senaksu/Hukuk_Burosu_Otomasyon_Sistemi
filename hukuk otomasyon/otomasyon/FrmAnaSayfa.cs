using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukuk_otomasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMuvekkilislem frmMuvekkilislemsec = new FrmMuvekkilislem();
            frmMuvekkilislemsec.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPersonelislem frmFrmPersonelislemsec = new FrmPersonelislem();
            frmFrmPersonelislemsec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDosyaislem frmDosyaislemsec = new FrmDosyaislem();
            frmDosyaislemsec.Show();
            this.Hide();
        }
    }
}
