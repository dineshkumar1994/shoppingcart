using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace ShoppingWebsite
{
    public class ShoppingStoreDeatils
    {
        public List<Album> Albums { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
    