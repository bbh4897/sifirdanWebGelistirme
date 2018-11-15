using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gu_Eclass
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Kategori k = new Kategori();
            VtContext vt = new VtContext();
            vt.Kategoriler.Add(k);
            vt.SaveChanges();
            Console.WriteLine("jkjkl");


        }
    }
}
