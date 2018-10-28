using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatikVeritabani.Models
{
    public static class Veritabani
    {
        public static List<Urun> _list;

        static Veritabani()
        {
            _list = new List<Urun>()
            {
                new Urun(){UrunId=1, UrunAd = "Urun 1"},
                new Urun(){UrunId=2, UrunAd = "Urun 2"},
                new Urun(){UrunId=3, UrunAd = "Urun 3"},
                new Urun(){UrunId=4, UrunAd = "Urun 4"},
                new Urun(){UrunId=5, UrunAd = "Urun 5"},
                new Urun(){UrunId=6, UrunAd = "Urun 6"},
                new Urun(){UrunId=7, UrunAd = "Urun 7"},
            };
        }

        public static List<Urun> Liste { get { return _list; } }

        public static void ekle(Urun urun)
        {
            _list.Add(urun);
        }

        public static Urun Detay(int urunId)
        {
            Urun entity = null;
            foreach (var item in _list)
            {                
                if (item.UrunId == urunId)
                {
                    entity = item;
                }
            }
            return entity;
        }
        
    }
}