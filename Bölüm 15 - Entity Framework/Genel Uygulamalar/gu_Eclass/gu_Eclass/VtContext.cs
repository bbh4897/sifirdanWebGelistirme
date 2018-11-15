using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gu_Eclass
{
    public class VtContext:DbContext
    {
        public VtContext():base("gu_EF")
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
