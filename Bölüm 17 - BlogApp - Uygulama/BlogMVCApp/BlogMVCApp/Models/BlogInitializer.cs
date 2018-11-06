using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {kategoriAdi="C#"},
                new Category() {kategoriAdi="Asp.Net MVC"},
                new Category() {kategoriAdi="Asp.Net WebForm"},
                new Category() {kategoriAdi="Windows Form"}
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
               new Blog() {Baslik="C# Delegates Hakkında", Aciklama="Acıklama 1",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Icerık 1", Resim="1.jpg", CategoryId=1},
               new Blog() {Baslik="Generic List Hakkında", Aciklama="Acıklama 2",EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=false, Onay=true, Icerik="Icerık 2", Resim="2.jpg", CategoryId=2},
               new Blog() {Baslik="Asp.Net Hakkında", Aciklama="Acıklama 3",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=false, Icerik="Icerık 3", Resim="3.jpg", CategoryId=3},
               new Blog() {Baslik="Java Delegates Hakkında", Aciklama="Acıklama 4",EklenmeTarihi=DateTime.Now.AddDays(-40), Anasayfa=true, Onay=false, Icerik="Icerık 4", Resim="4.jpg", CategoryId=4},
               new Blog() {Baslik="Android Delegates Hakkında", Aciklama="Acıklama 5",EklenmeTarihi=DateTime.Now.AddDays(-1), Anasayfa=true, Onay=false, Icerik="Icerık 5", Resim="5.jpg", CategoryId=1},
               new Blog() {Baslik="Veritabanı Delegates Hakkında", Aciklama="Acıklama 6",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="Icerık 6", Resim="6.jpg", CategoryId=3},
               new Blog() {Baslik="Sistem Programlama Delegates Hakkında", Aciklama="Acıklama 7",EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=false, Icerik="Icerık 7", Resim="7.jpg", CategoryId=4},
               new Blog() {Baslik="Ayrık Matematik Delegates Hakkında", Aciklama="Acıklama 8",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="Icerık 8", Resim="8.jpg", CategoryId=2}
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context); 
        }
    }
}