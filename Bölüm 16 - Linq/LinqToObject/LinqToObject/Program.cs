using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Elemanlarının karesını alma
            //int[] dizi = { 1, 2, 3, 4, 5 };
            //var sayilar = dizi.Select(i => i*i);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            // Dizi elemanları tek mı dıye sor
            //int[] dizi = { 1, 2, 3, 4, 5 };
            //var sayilar = dizi.Where(i => i%2==1);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            // Elemanları Sirala
            int[] dizi = { 100, 25, 3, 4343, 52 };
            var sayilar = dizi.OrderBy(i =>i);
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }


        }
    }
}
