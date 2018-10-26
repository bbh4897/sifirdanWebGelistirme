using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {


            // Uzun uzun bunları yapmaktansa...

            //int[] oge_no = { 100, 200, 300 };
            //String[] ad_soyad = { "Burcu", "Elif", "Sevde" };
            //String[] sube = { "10A", "10B", "10C" };

            //Console.WriteLine("Öğrenci Numarası : " + oge_no[0] + " Ad-Soyad : " + ad_soyad[0] + " Şube : " + sube[0]);
            //Console.WriteLine("Öğrenci Numarası : " + oge_no[1] + " Ad-Soyad : " + ad_soyad[1] + " Şube : " + sube[1]);
            //Console.WriteLine("Öğrenci Numarası : " + oge_no[2] + " Ad-Soyad : " + ad_soyad[2] + " Şube : " + sube[2]);


          



            // Birinci Class Yolu
            Ogrenci o = new Ogrenci();

            o.ogr_no = 100;
            o.ad_soyad = "Burcu";
            o.sube = "12060398";

            Console.WriteLine("Öğrenci Numarası : " + o.ogr_no + " Ad Soyad : " + o.ad_soyad + " Şube : " + o.sube);

            // İkincş Class Yolu
            Ogrenci o2 = new Ogrenci()
            {
                ogr_no = 200,
                ad_soyad = "Elif Sevde",
                sube = "1209856324"
            };

            Console.WriteLine("Öğrenci Numarası : " + o2.ogr_no + " Ad Soyad : " + o2.ad_soyad + " Şube : " + o2.sube);

            
            Console.WriteLine("*****************************************************");
            // Tek tek nesnelerı yazdırmaktansa dızı tanımlayıp yapmak daha basıt ( yıne yukarıdakı sekılde nesne atamaları tek tek yapılacak
            Ogrenci[] ogrenciler = new Ogrenci[2];

            ogrenciler[0] = o;  // nesne ısımlerı
            ogrenciler[1] = o2;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(" Öğrenci No : " + ogrenciler[i].ogr_no + " Adsoyad : " + ogrenciler[i].ad_soyad + " Şube : " + ogrenciler[i].sube);

            }


            

        }
    }


    class Ogrenci
    {
        public int ogr_no { get; set; }

        public String ad_soyad { get; set; }

        public String sube { get; set; }

    }

}
