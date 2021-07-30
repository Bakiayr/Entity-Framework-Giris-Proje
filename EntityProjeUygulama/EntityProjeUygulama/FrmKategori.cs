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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Kategori
                                        select new
                                        {
                                            x.ID,
                                            x.AD
                                        }).ToList();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.AD = txt_urunAdi.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi!!");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_urunID.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi!!!");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_urunID.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.AD = txt_urunAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori İsmi Güncellendi!!");
        }
    }
}
