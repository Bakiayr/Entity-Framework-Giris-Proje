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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun urun = new Tbl_Urun();
            urun.UrunAd = txt_urunAd.Text;
            urun.UrunMarka = txt_urunMarka.Text;
            urun.UrunStok = Convert.ToInt16( txt_urunStok.Text);
            urun.UrunKategori = Convert.ToInt32(cmb_urunKategori.SelectedValue.ToString());
            urun.UrunFiyat = Convert.ToDecimal(txt_urunFiyat.Text);
            urun.UrunDurum = true;
            db.Tbl_Urun.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Eklendi!!");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }).ToList();
            cmb_urunKategori.ValueMember = "ID";
            cmb_urunKategori.DisplayMember = "AD";
            cmb_urunKategori.DataSource = kategoriler;
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.UrunMarka,
                                            x.UrunFiyat,
                                            x.Tbl_Kategori.AD,
                                            x.UrunStok,
                                            x.UrunDurum
                                        }).ToList();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_urunID.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sistemden Silindi!!");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_urunID.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.UrunAd = txt_urunAd.Text;
            urun.UrunMarka = txt_urunMarka.Text;
            urun.UrunStok = Convert.ToInt16(txt_urunStok.Text);
            urun.UrunKategori = Convert.ToInt32(cmb_urunKategori.Text);
            urun.UrunFiyat = Convert.ToDecimal(txt_urunFiyat.Text);
            urun.UrunDurum = Convert.ToBoolean(txt_urunDurum.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi!!");
        }
    }
}
