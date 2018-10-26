using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci değeri giriniz : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci Değeri Girniz : ");
            int b = int.Parse(Console.ReadLine());

            int toplam = a + b;
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine($"Girilen Değerler Toplamı : {toplam}");
        }
    }
}
