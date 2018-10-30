using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecting
{
    public class LinqInitializer: DropCreateDatabaseIfModelChanges<VtContext>
    {
        protected override void Seed(VtContext context)
        {

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

            List<Urun> urun = new List<Urun>()
            {
                new Urun(){urunAdi="Iphone 7", Fiyat=3500.0,stok=1000, KategoriId=1},
                new Urun(){urunAdi="Iphone 6", Fiyat=1500.0,stok=10,KategoriId=1},
                new Urun(){urunAdi="SAmsung S-7", Fiyat=3000.0,stok=2000,KategoriId=1},
                new Urun(){urunAdi="Samsung Note3", Fiyat=2700,stok=0,KategoriId=1},
                new Urun(){urunAdi="Iphone x", Fiyat=15500.0,stok=1000,KategoriId=1},
               

                new Urun(){urunAdi="Bilgisayar 1", Fiyat=3500.0,stok=1000, KategoriId=2},
                new Urun(){urunAdi="Bilgisayar 2", Fiyat=1500.0,stok=10,KategoriId=2},
                new Urun(){urunAdi="Bilgisayar 3", Fiyat=3000.0,stok=2000,KategoriId=2},
                new Urun(){urunAdi="Bilgisayar 4", Fiyat=2700,stok=0,KategoriId=2},
                new Urun(){urunAdi="Bilgisayar 5", Fiyat=15500.0,stok=1000,KategoriId=2},
            };

            foreach (var item in urun)
            {
                context.Urunler.Add(item);
            }
            context.SaveChanges();

           

            base.Seed(context);
        }
    }
}
