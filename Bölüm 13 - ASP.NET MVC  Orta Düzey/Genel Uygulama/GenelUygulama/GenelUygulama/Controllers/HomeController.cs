using GenelUygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenelUygulama.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int[] dizi = { 341, 2234, 3 };
            return View(dizi);
        }
        public ActionResult ModelUrun()
        {
            List<Urun> urun = new List<Urun>
            {
                new Urun() {urunId=1,urunAdi="hhhl",fiyat=100},
                new Urun() {urunId=2,urunAdi="2adfsadf22",fiyat=5400},
                new Urun() {urunId=3,urunAdi="3332fsafa",fiyat=13200},
            };
            return View(urun);
        }

        public ActionResult ViewBagOrnek()
        {
            ViewBag.isim = "Burcu";
            return View();
        }

        public ActionResult MultipleModel()
        {

            List<Urun> urunler = new List<Urun>
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

            UrunKategori model = new UrunKategori();
            model.Urunler = urunler;
            model.Kategoriler = kategoriler;
            
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult PartialViewOrnek()
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

    }
}