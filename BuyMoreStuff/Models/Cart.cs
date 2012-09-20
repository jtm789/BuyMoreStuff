using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyMoreStuff.Models
{
    public class Cart
    {
        public List<Line> Lines { get; set; }
    }
}