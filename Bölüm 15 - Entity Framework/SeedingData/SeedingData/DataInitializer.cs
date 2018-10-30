using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedingData
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<VtContext>
    {
        protected override void Seed(VtContext context)
        {
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){Id=1, urunAdi="Iphone 7", Fiyat=3500.0},
                new Urun(){Id=2, urunAdi="Iphone 6", Fiyat=1500.0},
                new Urun(){Id=3, urunAdi="SAmsung S-7", Fiyat=3000.0},
                new Urun(){Id=4, urunAdi="Samsung Note3", Fiyat=2700},
                new Urun(){Id=5, urunAdi="Iphone x", Fiyat=15500.0,stok=1000}
            };
            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
