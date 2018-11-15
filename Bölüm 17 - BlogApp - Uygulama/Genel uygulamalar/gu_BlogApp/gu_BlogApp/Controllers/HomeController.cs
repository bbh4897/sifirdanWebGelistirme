using gu_BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gu_BlogApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            VtContext context = new VtContext();
            return View(context.Bloglar.ToList());
        }
    }
}