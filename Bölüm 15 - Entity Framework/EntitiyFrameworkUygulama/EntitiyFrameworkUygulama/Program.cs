using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******************************************************************************************************************************//
            //List<Kategori> kategori = new List<Kategori>()
            //{
            //    new Kategori(){Id=1,kategoriAdi="Telefon"},
            //    new Kategori(){Id=2,kategoriAdi="Bilgisayar"},
            //    new Kategori(){Id=3,kategoriAdi="Tablet"}
            //};


            //List<Urun> urun = new List<Urun>()
            //{
            //    new Urun(){Id=1, urunAdi="Iphone 7", Fiyat=3500.0,stok=1000},
            //    new Urun(){Id=2, urunAdi="Iphone 6", Fiyat=1500.0,stok=10},
            //    new Urun(){Id=3, urunAdi="SAmsung S-7", Fiyat=3000.0,stok=2000},
            //    new Urun(){Id=4, urunAdi="Samsung Note3", Fiyat=2700,stok=0},
            //    new Urun(){Id=5, urunAdi="Iphone x", Fiyat=15şl500.0,stok=1000},
            //};
            // ******************************************************************************************************************************//
            // Yeni Bir Kategori Ekleme İşlemi
            //Kategori k = new Kategori();
            //k.Id = 1;
            //k.kategoriAdi = "Telefon";

            //VtContext vc = new VtContext();
            //vc.Kategoriler.Add(k);
            //vc.SaveChanges();

            //Console.WriteLine("Veri Kayıt Edildi.");

            // ******************************************************************************************************************************//

            // LINQ 
            //VtContext context = new VtContext();
            //Urun urun = new Urun();
            //urun.urunAdi = "Samsung S4";
            //urun.Fiyat = 2000;
            //urun.stok = 100;


            //context.Urunler.Add(urun);

            //urun = new Urun();
            //urun.urunAdi = "Samsung S6";
            //urun.Fiyat = 3000;
            //urun.stok = 200;

            //context.Urunler.Add(urun);

            //context.SaveChanges();

            // Liste Seklınde daha kolay tanımlanabılır.
            VtContext context = new VtContext();
            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){Id=1, urunAdi="Iphone 7", Fiyat=3500.0,stok=1000},
                new Urun(){Id=2, urunAdi="Iphone 6", Fiyat=1500.0,stok=10},
                new Urun(){Id=3, urunAdi="SAmsung S-7", Fiyat=3000.0,stok=2000},
                new Urun(){Id=4, urunAdi="Samsung Note3", Fiyat=2700,stok=0},
                new Urun(){Id=5, urunAdi="Iphone x", Fiyat=15500.0,stok=1000},
            };

            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
            }
            context.SaveChanges();
        }
    }
}

