﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int idharga { get; set; }
        public string deskripsi { get; set; }
        public float rating { get; set; }
        public string gambar { get; set; }
        public int idToko { get; set; }
        public string tglPost { get; set; }
    }
}