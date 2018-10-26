using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{

    class Araba
    {
        public String marka { get; set; }
        public String model { get; set; }
        public String renk { get; set; }
        public Boolean otomatik { get; set; }

        public void yaz()
        {
            Console.WriteLine("Marka : " + this.marka + " Model : " + this.model + " Renk : " + this.renk + " Otomatik : " + this.otomatik);
        }

        public String yaz2()
        {
            return string.Format("Marka : " + this.marka + " Model : " + this.model + " Renk : " + this.renk + " Otomatik : " + this.otomatik);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Araba a = new Araba();
            a.marka = "Citroen";
            a.model = "C3";
            a.renk = "Siyah";
            a.otomatik = true;

            a.yaz();

           
            a.marka = "a";
            a.model = "aaa";
            a.renk = "aaaaa";
            a.otomatik = true;

            a.yaz();
            Console.WriteLine(a.yaz2());

        }
    }
}
