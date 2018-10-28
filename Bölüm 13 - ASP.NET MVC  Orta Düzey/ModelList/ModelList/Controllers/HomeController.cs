using ModelList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Urun> urun = new List<Urun>() {

                new Urun(){UrunId=1, UrunAdi = "Samsung S 6", Aciklama="İdare Eder", Satistami=true},
                new Urun(){UrunId=2, UrunAdi = "Samsung S 7", Aciklama="İdare Eder", Satistami=false},
                new Urun(){UrunId=3, UrunAdi = "Samsung S 8", Aciklama ="İyi",Satistami = true }
        };
            return View(urun);
    }
}
}