using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //For dongusu

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // While Dongusu
            int j = 0;
            while (j<10)
            {
                Console.WriteLine("While için j : " + j);
                j++;
            }

            //do-while dongusu
            int x = 0;
            do
            {
                Console.WriteLine("x : " + x);
                x++;
            } while (x<3);

            //foreach Dongusu

            string[] ogrenciler = { "a", "b", "c", "f", "j", "u", "j", "y", "o", "y" };
           
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
