using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gu_BlogApp.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string kategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}