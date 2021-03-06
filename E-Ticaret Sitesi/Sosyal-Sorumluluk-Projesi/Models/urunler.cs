namespace Sosyal_Sorumluluk_Projesi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunler")]
    public partial class urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urunler()
        {
            Arsivs = new HashSet<Arsiv>();
            yorums = new HashSet<yorum>();
        }

        [Key]
        public int urunID { get; set; }

        public int? kategoriID { get; set; }

        [StringLength(50)]
        public string urunAdi { get; set; }

        [StringLength(500)]
        public string urunİcerik { get; set; }

        public int? memleketID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        [StringLength(500)]
        public string resim { get; set; }

        public int? kullaniciID { get; set; }

        public int? yorumID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arsiv> Arsivs { get; set; }

        public virtual kategoriler kategoriler { get; set; }

        public virtual kullanicilar kullanicilar { get; set; }

        public virtual memleket memleket { get; set; }

        public virtual yorum yorum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yorum> yorums { get; set; }
    }
}
