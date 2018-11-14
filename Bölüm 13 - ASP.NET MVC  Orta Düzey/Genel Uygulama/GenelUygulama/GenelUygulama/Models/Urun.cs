using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenelUygulama.Models
{
    public class Urun
    {
        public int urunId { get; set; }
        public string urunAdi { get; set; }
        public double fiyat { get; set; }
    }
}