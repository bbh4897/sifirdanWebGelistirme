using gu_UrunEkle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gu_UrunEkle.Controllers
{
    public class HomeController : Controller
    {
        List<Urun> urun = new List<Urun>();
        // GET: Home
        public ActionResult Index()
        {
            urun = Veritabani.List;
            return View(urun);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(Urun u)
        {
            
                Veritabani.UrunEkle(u);
            
            return View("Index",Veritabani.List);
        }
    }
}