using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtilimElektrik.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Hizmetlerimiz()
        {
            return View();
        }

        public ActionResult Urunlerimiz()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
    }
}