using gu_UrunDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gu_UrunDetails.Controllers
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

        public ActionResult Details(int Id)
        {
            Urun entity=null;
            foreach (var item in Veritabani.List)
            {
                if (item.urunId == Id)
                {
                    entity = item;
                }
            }
            return View(entity);
        }
    }
}