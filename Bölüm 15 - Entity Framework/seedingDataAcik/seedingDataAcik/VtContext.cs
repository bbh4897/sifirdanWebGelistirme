using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seedingDataAcik
{
    public class VtContext: DbContext
    {
        public VtContext(): base("sdngData")
        {
            Database.SetInitializer(new DataInitializer());  // Inıtılaizer sınıfından haberdar ettık.
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
