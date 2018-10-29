using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkUygulama
{
    public class Urun
    {
        //Varsayılan olarak otomatik sayı olarak ayarlanır. PrimaryKey olarak ayarlanır.(ısmı Id olmalı)
        public int Id { get; set; } // Özellikle Id adını almalı
        public string urunAdi { get; set; }
        public double Fiyat { get; set; }
        public int stok { get; set; }
    }
}
