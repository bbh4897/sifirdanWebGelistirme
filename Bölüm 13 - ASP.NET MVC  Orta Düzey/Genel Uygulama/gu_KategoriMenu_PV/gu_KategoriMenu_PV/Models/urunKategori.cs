using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gu_KategoriMenu_PV.Models
{
    public class urunKategori
    {
        public List<Urun> Urunler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}