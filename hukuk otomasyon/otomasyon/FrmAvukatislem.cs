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
    public partial class FrmAvukatislem : Form
    {
        public FrmAvukatislem()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfasec = new FrmAnaSayfa();
            frmAnaSayfasec.Show();
            this.Hide();
        }
    }
}
