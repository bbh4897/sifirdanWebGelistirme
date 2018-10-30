using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seedingDataAcik
{
    public class DataInitializer: DropCreateDatabaseAlways<VtContext>
    {
        protected override void Seed(VtContext context)
        {
            List<Urun> urun = new List<Urun>()
            {
                new Urun(){Id=1, urunAdi="Iphone 7", Fiyat=3500.0,stok=1000, KategoriId=1},
                new Urun(){Id=2, urunAdi="Iphone 6", Fiyat=1500.0,stok=10,KategoriId=1},
                new Urun(){Id=3, urunAdi="SAmsung S-7", Fiyat=3000.0,stok=2000,KategoriId=1},
                new Urun(){Id=4, urunAdi="Samsung Note3", Fiyat=2700,stok=0,KategoriId=1},
                new Urun(){Id=5, urunAdi="Iphone x", Fiyat=15500.0,stok=1000,KategoriId=1},
            };

            foreach (var item in urun)
            {
                context.Urunler.Add(item);
            }
            context.SaveChanges();

            List<Kategori> kategori = new List<Kategori>()
            {
                new Kategori(){Id=1,KategoriAdi="Telefon"},
                new Kategori(){Id=2,KategoriAdi="Bilgisayar"},
                new Kategori(){Id=3,KategoriAdi="Tablet"}
            };

            foreach (var item in kategori)
            {
                context.Kategoriler.Add(item);
            }


            context.SaveChanges();

            base.Seed(context); 
        }
    }
}
