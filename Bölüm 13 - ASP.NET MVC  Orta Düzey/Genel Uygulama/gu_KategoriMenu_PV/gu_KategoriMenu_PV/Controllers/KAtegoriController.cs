using gu_KategoriMenu_PV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gu_KategoriMenu_PV.Controllers
{
    public class KAtegoriController : Controller
    {
        // GET: KAtegori
        public ActionResult Index()
        {
            
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>
            {
                new Kategori() {kategoriId=1, kategoriAdi="Kategori 1"},
                new Kategori() {kategoriId=2, kategoriAdi="Kategori 2"},
                new Kategori() {kategoriId=3, kategoriAdi="Kategori 3"},
                new Kategori() {kategoriId=4, kategoriAdi="Kategori 4"}
            };
            return PartialView("KategoriMenu",kategoriler);
        }
    }
}