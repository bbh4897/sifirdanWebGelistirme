using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikMetod
{

    static class Helper
    {
        public static String KarakterDuzelt(String str)
        {
            return str
                .Replace("ç", "c")
                .Replace("Ö", "O")
                .Replace("ğ", "g")
                .Replace("ü", "u");            
        }
    }

    class Urun
    {
        public int id { get; set; }
        public String UrunAdi { get; set; }
        public String UrunFiyat { get; set; }
        public String Aciklama { get; set; }
    }

    static class Veritabani
    {
        static Urun[] urunler;

        static Veritabani()
        {
            urunler = new Urun[4];
            urunler[0] = new Urun() { id = 1, UrunAdi = "Urun 1", UrunFiyat = "15 tl", Aciklama = "nhjhkh" };
            urunler[1] = new Urun() { id = 2, UrunAdi = "Urun 2", UrunFiyat = "45 tl", Aciklama = "esfsd" };
            urunler[2] = new Urun() { id = 3, UrunAdi = "Urun 3", UrunFiyat = "33 tl", Aciklama = "nhfdsfwe5yrujhkh" };
            urunler[3] = new Urun() { id = 4, UrunAdi = "Urun 4", UrunFiyat = "1225 tl", Aciklama = "nhjyturefwedchkh" };
        }

        public static Urun[] urunGetir()
        {
            return urunler;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String str = "Ölçme ve Değerlendirme";

            str = Helper.KarakterDuzelt(str);

            Urun[] urunler = Veritabani.urunGetir();
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün adı : " + urun.UrunAdi + " Urun Id: " + urun.id + "Urun Fıyat : " + urun.UrunFiyat + "Urun Acıklama : " + urun.Aciklama);
            }
            Console.WriteLine(str);
            Console.Read();

        }
    }
}
