using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gu_BlogApp.Models
{
    public class VtContext:DbContext
    {
        public VtContext():base("BlogApp")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}