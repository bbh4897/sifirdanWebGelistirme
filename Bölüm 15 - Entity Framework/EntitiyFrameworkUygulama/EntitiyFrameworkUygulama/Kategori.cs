﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkUygulama
{
    public class Kategori
    {
        //Varsayılan olarak otomatik sayı olarak ayarlanır.PrimaryKey olarak ayarlanır.(ısmı Id olmalı)
        public int Id { get; set; }
        public string kategoriAdi { get; set; }
    }
}
