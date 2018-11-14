using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenelUygulama.Models
{
    public class UrunKategori
    {
        public List<Urun> Urunler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}