using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedingData
{


    public class VtContext : DbContext
    {
        public VtContext() : base("dbCon")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Urun> Urunler { get; set; }
    }
}
