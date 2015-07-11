using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_MicroService_Sh.Models
{
    public class ShoppingCartDTO
    {
        public ShoppingCartDTO()
        {
            items = new List<Item>();
        }
        public string name { get; set; }
        public List<Item> items { get; set; }

    }

    public static class ShoppingCartRepository
    {
        public static ShoppingCartDTO GetCart()
        {
            return new ShoppingCartDTO()
            {
                items = new List<Item>{
                    new Item(){ name = "Alienware PC", price = "$2200.00", quantity = "1"  },
                    new Item(){ name = "Canali Suit", price = "$1200.00", quantity = "1"  },
                    new Item(){ name = "PacMan Cuflinks", price = "$35.00", quantity = "1"  }
                },
                name = "Senior Associate"
            };
        }
    }
}
