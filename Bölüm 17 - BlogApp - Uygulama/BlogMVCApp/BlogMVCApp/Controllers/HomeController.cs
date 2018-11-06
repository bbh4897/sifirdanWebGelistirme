
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar.Select(i=> new BlogModel()
            {
                Id=i.Id,
                Baslik=i.Baslik.Length>100?i.Baslik.Substring(0,10) + "..." : i.Baslik,
                Resim = i.Resim,
                EklenmeTarihi = i.EklenmeTarihi,
                Onay = i.Onay,
                Anasayfa = i.Anasayfa
            })
            .Where(i => i.Onay == true && i.Anasayfa == true);
            return View(bloglar.ToList());
        }
    }
}

