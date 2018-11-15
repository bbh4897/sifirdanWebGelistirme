using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gu_UrunDetails.Models
{
    public static class Veritabani
    {
        public static List<Urun> liste;

        static Veritabani()
        {
            liste = new List<Urun>()
            {
                new Urun(){urunId=1, urunAdi="A Urunu",urunFiyat=100},
                new Urun(){urunId=2, urunAdi="b Urunu",urunFiyat=300},
                new Urun(){urunId=3, urunAdi="d Urunu",urunFiyat=150},
                new Urun(){urunId=4, urunAdi="7 Urunu",urunFiyat=70},
                new Urun(){urunId=5, urunAdi="g Urunu",urunFiyat=400}
            };
        }

        public static List<Urun> List
        {
            get
            {
                return liste;
            }
        }



    }
}