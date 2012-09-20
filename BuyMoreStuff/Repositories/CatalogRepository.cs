using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuyMoreStuff.Models;

namespace BuyMoreStuff.Repositories
{
    public class CatalogRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            yield return new Product { Id = 1, Name = "Hydro Spanner", UnitPrice = 13.49m };
            yield return new Product { Id = 2, Name = "Flux Capacitor", UnitPrice = 434.99m };
            yield return new Product { Id = 3, Name = "Hyperdrive Coil", UnitPrice = 2341.49m };
        }
    }
}