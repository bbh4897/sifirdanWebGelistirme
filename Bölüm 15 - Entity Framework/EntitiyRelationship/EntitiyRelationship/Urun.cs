using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyRelationship
{
    public class Urun
    {
        [Key]
        public int urunId { get; set; }
        public String urunAdi { get; set; }
        public double Fiyat { get; set; }
        public int stok { get; set; }

        public int KategoriId { get; set; }  // Sınıf adı + Id (Arada boşluk olmayack.O otomatik olarak onu fk olarak algılıyor.Tablolar bagşanmıs oldu
        public Kategori Kategori { get; set; } // Veritabanında olusmayacak sadece program anında kullanıcaz.
        public List<Tedarikci> Tedarikciler { get; set; }
    }
}
