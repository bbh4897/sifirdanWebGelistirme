using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecting
{
    class Program
    {
        static void Main(string[] args)
        {
            VtContext context = new VtContext();

            var urunler = context.Urunler.ToList();
            foreach (var item in urunler)
            {
                Console.WriteLine("urunId : {0} ---  Urun Adı : {1} --- Urun Fiyatı : {2} ---  Urun Stok : {3} -- Urun Kategori : {4}", item.Id,item.urunAdi , item.Fiyat, item.stok, item.KategoriId);
            }

        }
    }
}
