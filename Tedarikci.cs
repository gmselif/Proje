namespace Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tedarikci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tedarikci()
        {
            Uruns = new HashSet<Urun>();
        }

        public int tedarikciID { get; set; }

        public string tName { get; set; }

        public int getirdigiUrunMiktari { get; set; }

        public int birimGirdiFiyati { get; set; }

        public int tedarikciyeOlanBorc { get; set; }

        public int odenmisFiyat { get; set; }

        public int odenecekFiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
