﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyMoreStuff.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}