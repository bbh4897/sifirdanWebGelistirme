using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seedingDataAcik
{
    public class Urun
    {
        public int Id { get; set; }
        public string urunAdi { get; set; }
        public double Fiyat { get; set; }
        public int stok { get; set; }
        public int KategoriId { get; set; }
    }
}
