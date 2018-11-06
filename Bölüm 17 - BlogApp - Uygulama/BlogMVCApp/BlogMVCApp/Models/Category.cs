using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string kategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}