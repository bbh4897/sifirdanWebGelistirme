using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{

    class Urun
    {
        public int UrunId { get; set; }
        public String UrunAdi { get; set; }
        public String UrunFiyat { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Bırıncı Yontem
            List<String> isim = new List<String>();
            isim.Add("Burcu");
            isim.Add("Elif Sevde");

            // ıkıncı Yontem
            List<int> sayilar = new List<int>() { 10, 20, 30 };


            // Uucncu Yontem
            List<Urun> urunler = new List<Urun>()
            {
                new Urun()
                {
                    UrunId=1,
                    UrunAdi = "Urun 1",
                    UrunFiyat = "243lk3j2lk"
                },

                new Urun()
                {
                    UrunId=2,
                    UrunAdi = "Urun 2",
                    UrunFiyat = "asfsfds"
                }
            };
            urunler.Add(new Urun()
            {
                UrunId = 3,
                UrunAdi = "Urun 3",
                UrunFiyat = "asfsfds"
            });


            // Lıstelere Ulasım
            for (int i = 0; i < isim.Count; i++)
            {
                Console.WriteLine(isim[i]);
            }


            for (int i = 0; i < urunler.Count; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi);
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }
        }
    }
}
