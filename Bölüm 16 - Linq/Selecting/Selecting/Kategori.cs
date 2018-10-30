using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecting
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Urun> Urunler { get; set; } // Kategori ile Urunler arası baglantı
    }
}
