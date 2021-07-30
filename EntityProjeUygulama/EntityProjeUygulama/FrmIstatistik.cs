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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lbl_topKategori.Text = db.Tbl_Kategori.Count().ToString();
            lbl_topUrun.Text = db.Tbl_Urun.Count().ToString();
            lbl_aktifMusteri.Text = db.Tbl_Musteri.Count(x => x.MusteriDurum == true).ToString();
            lbl_pasifMusteri.Text = db.Tbl_Musteri.Count(x => x.MusteriDurum == false).ToString();
            lbl_topStok.Text = db.Tbl_Urun.Sum(y => y.UrunStok).ToString();
            lbl_kasaTutar.Text = db.Tbl_Satis.Sum(z => z.Fiyat).ToString() + "TL";

            // descending -> Z den A ya sırala - En yüksek fiyatlı ürün ilk sırada olacak
            // ascending -> A dan Z ye sırala - En düşük fiyatlı ürün ilk sırada olacak        !  En yukardaki ürünü çekme methodu !
            lbl_yuksekFiyat.Text = (from x in db.Tbl_Urun orderby x.UrunFiyat descending select x.UrunAd).FirstOrDefault();
            lbl_dusukFiyat.Text = (from y in db.Tbl_Urun orderby y.UrunFiyat ascending select y.UrunAd).FirstOrDefault();
            lbl_beyazEsya.Text = db.Tbl_Urun.Count(x => x.UrunKategori == 1).ToString();
            lbl_topBuzdolabi.Text = db.Tbl_Urun.Count(z => z.UrunAd == "Buzdolabı").ToString();
                                                                                 // Tekrarsız 
            lbl_sehirSayisi.Text = (from z in db.Tbl_Musteri select z.MusteriSehir).Distinct().Count().ToString();
                                      //PROCEDURE
            lbl_maxUrunMarka.Text = db.MarkaGetir().FirstOrDefault();
            
        }
    }
}
