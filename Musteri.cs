namespace Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Uruns = new HashSet<Urun>();
        }

        public int musteriID { get; set; }

        public string mName { get; set; }

        public string odemeYontemi { get; set; }

        public int aldigiTarih { get; set; }

        public int aldigiUrunMiktari { get; set; }

        public int borc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
