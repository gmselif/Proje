using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Product
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Satici> Saticis { get; set; }
        public virtual DbSet<Tedarikci> Tedarikcis { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Uruns)
                .WithOptional(e => e.Musteri)
                .HasForeignKey(e => e.Musteri_musteriID);

            modelBuilder.Entity<Tedarikci>()
                .HasMany(e => e.Uruns)
                .WithOptional(e => e.Tedarikci)
                .HasForeignKey(e => e.Tedarikci_tedarikciID);
        }
    }
}
