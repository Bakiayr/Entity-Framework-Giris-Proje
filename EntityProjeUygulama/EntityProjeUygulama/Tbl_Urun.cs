//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeUygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Urun()
        {
            this.Tbl_Satis = new HashSet<Tbl_Satis>();
        }
    
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public Nullable<short> UrunStok { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public Nullable<bool> UrunDurum { get; set; }
        public Nullable<int> UrunKategori { get; set; }
    
        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satis> Tbl_Satis { get; set; }
    }
}
