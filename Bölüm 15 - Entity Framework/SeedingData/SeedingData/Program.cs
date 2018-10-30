using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedingData
{
    class Program
    {
        static void Main(string[] args)
        {
            VtContext context = new VtContext();

            var liste= context.Urunler.ToList();
            foreach (var item in liste)
            { 
                Console.WriteLine(item.Id);
            }
        }
    }
}
