using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodUygulama
{
    // Instance Metodlar
    class Araba
    {
        public void Start()
        {
            Console.WriteLine("Araba Çalıştı");
        }

        public void Stop()
        {
            Console.WriteLine("Araba Durdu");
        }

        public void Yavasla()
        {
            Console.WriteLine("Araba Yavaşlıyor");
        }

        public void Hizlan()
        {
            Console.WriteLine("Araba Hızlanıyor");
        }

        public void Menu()
        {
            string komut = "";
            do
            {
                Console.WriteLine("Seçiminiz : ");
                Console.WriteLine("1 - Start, 2 - Stop, 3 - Yavaşla, 4 - Hızlan");
                komut = Console.ReadLine();

                switch (komut)
                {
                    case "1":
                        this.Start();
                    break;

                    case "2":
                        this.Stop();
                    break;

                    case "3":
                        this.Yavasla();
                    break;

                    case "4":
                        this.Hizlan();
                    break;
                    default:
                        Console.WriteLine("Hatalı Giriş");
                    break;
                }
            } while (komut != "a");

        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Araba a = new Araba();
            //a.Start();
            //a.Stop();
            //a.Hizlan();
            //a.Yavasla();

            a.Menu();

            
        }
    }
}
