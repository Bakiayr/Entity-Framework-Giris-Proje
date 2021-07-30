using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            DbEntityUrunEntities db = new DbEntityUrunEntities();

            var sorgu = from x in db.Tbl_Admin where x.AdminKullanıcıAd == txt_kullaniciAdi.Text && x.AdminSifre == txt_Sifre.Text select x;

            if (sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz!");

        }
    }
}
