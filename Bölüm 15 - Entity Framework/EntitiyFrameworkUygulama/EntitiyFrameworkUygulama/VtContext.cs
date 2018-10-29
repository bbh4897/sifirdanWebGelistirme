using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkUygulama
{
    public class VtContext : DbContext
    {
        public VtContext() : base("urunConnection")
        {
                
        }
        public DbSet<Urun> Urunler { get; set; } // Daha once UrunKategori.cs Sınıfında yapmıstık (List<Urun>...)
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
