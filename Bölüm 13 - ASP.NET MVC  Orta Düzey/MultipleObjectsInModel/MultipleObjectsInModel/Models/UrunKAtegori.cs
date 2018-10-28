using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleObjectsInModel.Models
{
    public class UrunKAtegori
    {
        public List<Urun> Urunler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public int UrunSayisi { get; set; }


    }
}