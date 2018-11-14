using gu_KategoriMenu_PV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gu_KategoriMenu_PV.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Urun> urun = new List<Urun>
            {
                new Urun() {urunId=1,urunAdi="hhhl",fiyat=100},
                new Urun() {urunId=2,urunAdi="2adfsadf22",fiyat=5400},
                new Urun() {urunId=3,urunAdi="3332fsafa",fiyat=13200},
            };

            List<Kategori> kategoriler = new List<Kategori>
            {
                new Kategori() {kategoriId=1, kategoriAdi="Kategori 1"},
                new Kategori() {kategoriId=2, kategoriAdi="Kategori 2"},
                new Kategori() {kategoriId=3, kategoriAdi="Kategori 3"},
                new Kategori() {kategoriId=4, kategoriAdi="Kategori 4"}
            };

            urunKategori model = new urunKategori();
            model.Urunler = urun;
            model.Kategoriler = kategoriler;
            return View(model);
        }

        public ActionResult Kategoriler()
        {
            List<Kategori> kategoriler = new List<Kategori>
            {
                new Kategori() {kategoriId=1, kategoriAdi="Kategori 1"},
                new Kategori() {kategoriId=2, kategoriAdi="Kategori 2"},
                new Kategori() {kategoriId=3, kategoriAdi="Kategori 3"},
                new Kategori() {kategoriId=4, kategoriAdi="Kategori 4"}
            };
            return View(kategoriler);
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}