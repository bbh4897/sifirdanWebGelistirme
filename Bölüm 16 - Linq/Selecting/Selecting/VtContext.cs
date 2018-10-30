using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecting
{
    public class VtContext : DbContext
    {
        public VtContext() : base("linq")
        {
            Database.SetInitializer(new LinqInitializer());  // Inıtılaizer sınıfından haberdar ettık.
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
