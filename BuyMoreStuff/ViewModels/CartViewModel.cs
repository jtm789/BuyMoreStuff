using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuyMoreStuff.Models;

namespace BuyMoreStuff.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public List<Product> Products { get; set; }

        public Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}