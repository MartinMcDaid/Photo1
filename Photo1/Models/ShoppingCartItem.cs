using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo1.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Photo CartPhoto { get; set; }

        public int Amount { get; set; }

        public string CartId { get; set; }
    }
}
