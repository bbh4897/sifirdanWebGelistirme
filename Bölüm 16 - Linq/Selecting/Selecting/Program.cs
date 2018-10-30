using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecting
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************************************************
            // Tüm Ürünleri Listeleme
            //VtContext context = new VtContext();

            //var urunler = context.Urunler.ToList();
            //foreach (var item in urunler)
            //{
            //    Console.WriteLine("urunId : {0} ---  Urun Adı : {1} --- Urun Fiyatı : {2} ---  Urun Stok : {3} -- Urun Kategori : {4}", item.Id,item.urunAdi , item.Fiyat, item.stok, item.KategoriId);
            //}


            // *********************************************************************************************

            // Belirli Tablo Alanlarını Secme
            //VtContext context = new VtContext();
            //var urun = context.Urunler.Select(i => new
            //{
            //    i.urunAdi,
            //    urun_fiyat = i.Fiyat // Değişkene de Atayabılırız
            //}).ToList();

            //foreach (var item in urun)
            //{
            //    Console.WriteLine("Urun Adı : {0} , Urun Fiyat : {1}", item.urunAdi , item.urun_fiyat);
            //}

            // *********************************************************************************************

            // Urun ısım uzunlukları 5 karakterden buyuk olanları ıllk 5 kısım al 
            //VtContext context = new VtContext();
            //var urun = context.Urunler.Select(i => new
            //{
            //    urun_adi = i.urunAdi.Length>5 ? i.urunAdi.Substring(0,5) + "..." : i.urunAdi,
            //    urun_fiyat = i.Fiyat // Değişkene de Atayabılırız
            //}).ToList();

            //foreach (var item in urun)
            //{
            //    Console.WriteLine("Urun Adı : {0} , Urun Fiyat : {1}", item.urun_adi, item.urun_fiyat);
            //}

            // *********************************************************************************************

            // Urunler lıstelenırken bız kategorıId sını degıl de kategorı ısımlerını gormek ısteyebılırız.

            //VtContext context = new VtContext();
            //var urun = context.Urunler.Select(i => new
            //{
            //    i.urunAdi,
            //   i.Kategori.KategoriAdi
            //}).ToList();

            //foreach (var item in urun)
            //{
            //    Console.WriteLine("Urun Adı : {0} , Urun Kategori : {1}", item.urunAdi, item.KategoriAdi);
            //}

            // *********************************************************************************************

            // Herbir kategoriyi alıp urunlere ulasma

            //VtContext context = new VtContext();

            //var kategori = context.Kategoriler.Select(i => new
            //{
            //    i.KategoriAdi,
            //    i.Urunler // Liste turunde ----- i.Urunler.Select() burda da yapılabılır cunku urunlerın tum alanlarını degıl de yalnızca belırlı alanları kullanmak ısteyebılırız. yok yere fazladan alanları yuklememk adına
                
            //}).ToList();

            //foreach (var item in kategori)
            //{
            //    Console.WriteLine("Kategori Adı : {0}",item.KategoriAdi);
            //    foreach (var urun in item.Urunler)
            //    {
            //        Console.WriteLine("Urun Adı : {0} , Urun Fiyat : {1} , Kategori Adı: {2}", urun.urunAdi, urun.Fiyat,item.KategoriAdi);
            //    }

            //}

        }
    }
}
