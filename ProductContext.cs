using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entity
{
    public class ProductContext : DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Satici> Saticis { get; set; }

    }
}
