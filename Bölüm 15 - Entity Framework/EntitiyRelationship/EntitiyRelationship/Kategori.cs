using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyRelationship
{
    public class Kategori
    {
        public int Id { get; set; }
        public string kategoriAdi { get; set; }

        public List<Urun> Urunler { get; set; } // Program anında kullanılacak Db de olusmayacak
    }
}
