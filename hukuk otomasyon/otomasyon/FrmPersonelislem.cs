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
    public partial class FrmPersonelislem : Form
    {
        public FrmPersonelislem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfasec = new FrmAnaSayfa();
            frmAnaSayfasec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAvukatislem frmAvukatislemsec = new FrmAvukatislem();
            frmAvukatislemsec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStajyerislem frmStajyerislemsec = new FrmStajyerislem();
            frmStajyerislemsec.Show();
            this.Hide();
        }
    }
}
