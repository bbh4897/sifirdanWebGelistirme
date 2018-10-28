using StatikVeritabani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StatikVeritabani.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UrunKategori model = new UrunKategori();
            model.Urunler = Veritabani.Liste;

            return View(model);
        }
    }
}