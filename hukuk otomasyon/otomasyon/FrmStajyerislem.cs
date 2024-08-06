using System;
using Npgsql;
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
    public partial class FrmStajyerislem : Form
    {
        public FrmStajyerislem()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=locaHost; port=5432; Database=dbburootomasyon; user Id=postgres; password=1357");
        private void BtnEkle_Click(object sender, EventArgs e)
        {


        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            
            if (baglanti!=null)
            {
                MessageBox.Show("veritabanına bağlanıldı");
            }
            baglanti.Open();
            DataSet dt = new DataSet();
            string sorgu = "select * from kisi";
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, baglanti);
            adap.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();

        }
    }
}


