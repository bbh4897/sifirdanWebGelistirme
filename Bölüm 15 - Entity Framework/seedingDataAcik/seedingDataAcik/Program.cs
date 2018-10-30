using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seedingDataAcik
{
    class Program
    {
        static void Main(string[] args)
        {
            VtContext context = new VtContext();
            var urun = context.Urunler.ToList();

            foreach (var item in urun)
            {
                Console.WriteLine("Urun adı : {0}", item.urunAdi);
            }

            Console.WriteLine("DB Olustu.");
            

        }
    }
}
