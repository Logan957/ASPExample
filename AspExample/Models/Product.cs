﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspExample.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
}
