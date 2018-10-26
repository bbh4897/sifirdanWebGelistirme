using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetod
{

    class Araba
    {
        public String Marka { get; set; }
        public String Model { get; set; }
        public String Renk { get; set; }
        public Boolean Otomatik { get; set; }
        

        public Araba()
        {
            Console.WriteLine("Yapıcı Metod Çalışıyor");
        }

        public Araba(String Marka, String Model, String Renk, Boolean Otomatik)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Renk = Renk;
            this.Otomatik = Otomatik;
        }

        public void Menu()
        {
            Console.WriteLine($"Marka : {Marka}, Model : {Model}, Renk : {Renk}, Otomatik : {Otomatik}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Araba a = new Araba();
            a.Marka = "Citroen";
            a.Model = "C3";
            a.Renk = "Siyah";
            a.Otomatik = true;
            a.Menu();


            // Kısa Yol
            Araba a2 = new Araba("Opel","Astra","Siyah",true);
            a2.Menu();

        }
    }
}
