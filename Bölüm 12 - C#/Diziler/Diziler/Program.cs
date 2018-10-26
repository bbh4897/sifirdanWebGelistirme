using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç elemanlı dizi olusturmak istiyorsunuz :");
            int adet = int.Parse(Console.ReadLine());

            int[] ogr_no = new int[adet];
            string[] ad_soyad = new string[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine((i+1)+". Öğrencinin numarası : ");
                ogr_no[i] = int.Parse(Console.ReadLine());

                Console.WriteLine((i + 1) + ". Öğrencinin adı ve soyadı : ");
                ad_soyad[i] = Console.ReadLine();

                Console.WriteLine("*******************************");
            }
            for (int i = 0; i < adet; i++)
            {

                Console.WriteLine((i+1)+". Öğrencinin numarası : "+ ogr_no[i] + " Adı ve Soyadı : " + ad_soyad[i]);

            }
            
        }
    }
}
