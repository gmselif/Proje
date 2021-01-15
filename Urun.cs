namespace Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Urun
    {
        [Key]
        public int urunKodu { get; set; }

        public int barkodNo { get; set; }

        public int satisFiyati { get; set; }

        public int tarih { get; set; }

        public int irsaliyeNo { get; set; }

        public int birimGirdiFiyati { get; set; }

        public int depodakiMiktar { get; set; }

        public int? Musteri_musteriID { get; set; }

        public int? Tedarikci_tedarikciID { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Tedarikci Tedarikci { get; set; }
    }
}
