using MultipleObjectsInModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleObjectsInModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Urun> urun = new List<Urun>()
            {
                new Urun(){UrunId=1, UrunAdi="Urun 1", Aciklama="jkjkhj"},
                new Urun(){UrunId=2, UrunAdi="Urun 2", Aciklama="sgfdggh"},
                new Urun(){UrunId=3, UrunAdi="Urun 3", Aciklama="jkjkhklpoıuytrewasdhj"}
            };


            List<Kategori> kategori = new List<Kategori>()
            {
                new Kategori(){KategoriId=1, KategoriAdi="KategoriAdi 1"},
                new Kategori(){KategoriId=2, KategoriAdi="KategoriAdi 2"},
                new Kategori(){KategoriId=3, KategoriAdi="KategoriAdi 3"}
            };


           UrunKAtegori model = new UrunKAtegori();

            model.Urunler = urun;
            model.Kategoriler = kategori;
            model.UrunSayisi = urun.Count();

           
            return View(model);
        }
    }
}