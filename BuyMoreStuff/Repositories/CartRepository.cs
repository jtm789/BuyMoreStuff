using System.Collections.Generic;
using BuyMoreStuff.Models;

namespace BuyMoreStuff.Repositories
{
    public class CartRepository
    {
        public Cart LoadCart()
        {
            return new Cart
            {
                Lines = new List<Line>
                {
                    new Line { ProductId = 1, Quantity = 7 },
                    new Line { ProductId= 2, Quantity = 1 }
                }
            };
        }
    }
}
