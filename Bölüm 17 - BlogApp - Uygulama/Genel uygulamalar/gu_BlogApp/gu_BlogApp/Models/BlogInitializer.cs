using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gu_BlogApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<VtContext>
    {

        protected override void Seed(VtContext context)
        {

            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() {kategoriAdi="C#"},
                new Kategori() {kategoriAdi="Asp.Net MVC"},
                new Kategori() {kategoriAdi="Asp.Net WebForm"},
                new Kategori() {kategoriAdi="Windows Form"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
               new Blog() {Baslik="C# Delegates Hakkında", Aciklama="Acıklama 1",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Icerık 1", Resim="1.jpg", kategoriId=1},
               new Blog() {Baslik="Generic List Hakkında", Aciklama="Acıklama 2",EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=true, Onay=true, Icerik="Icerık 2", Resim="2.jpg", kategoriId=2},
               new Blog() {Baslik="Asp.Net Hakkında", Aciklama="Acıklama 3",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=false, Icerik="Icerık 3", Resim="3.jpg", kategoriId=3},
               new Blog() {Baslik="Java Delegates Hakkında", Aciklama="Acıklama 4",EklenmeTarihi=DateTime.Now.AddDays(-40), Anasayfa=true, Onay=false, Icerik="Icerık 4", Resim="4.jpg", kategoriId=4},
               new Blog() {Baslik="Android Delegates Hakkında", Aciklama="Acıklama 5",EklenmeTarihi=DateTime.Now.AddDays(-1), Anasayfa=true, Onay=true, Icerik="Icerık 5", Resim="5.jpg", kategoriId=1},
               new Blog() {Baslik="Veritabanı Delegates Hakkında", Aciklama="Acıklama 6",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="Icerık 6", Resim="6.jpg", kategoriId=3},
               new Blog() {Baslik="Sistem Programlama Delegates Hakkında", Aciklama="Acıklama 7",EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=false, Icerik="Icerık 7", Resim="7.jpg", kategoriId=4},
               new Blog() {Baslik="Ayrık Matematik Delegates Hakkında", Aciklama="Acıklama 8",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Icerık 8", Resim="8.jpg", kategoriId=2}
            };

            foreach (var blog in bloglar)
            {
                context.Bloglar.Add(blog);
            }
            context.SaveChanges();

            base.Seed(context);

        }
    }
}