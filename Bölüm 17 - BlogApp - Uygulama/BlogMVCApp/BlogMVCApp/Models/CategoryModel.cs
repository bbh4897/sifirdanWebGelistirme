﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string kategoriAdi { get; set; }
        public int BlogSayisi { get; set; }
    }
}