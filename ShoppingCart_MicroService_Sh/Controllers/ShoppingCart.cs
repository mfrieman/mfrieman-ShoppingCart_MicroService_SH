using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart_MicroService_Sh.Models;

namespace ShoppingCart_MicroService_Sh.Controllers
{
    public class ShoppingCartController : ApiController
    {
        // GET: api/ShoppingCart
        public ShoppingCartDTO Get()
        {
            return ShoppingCartRepository.GetCart();
        }
    }
}
