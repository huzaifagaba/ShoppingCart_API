using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart_API.Models;


namespace ShoppingCart_API.Controllers
{
    public class MyShoppingCartController : ApiController
    {
        [Route("api/GetProducts")]
        [HttpGet]
        public List<Product> GetProducts()
        {

            MyShoppingCartEntities db = new MyShoppingCartEntities();


            db.Configuration.ProxyCreationEnabled = false;

            return db.Products.ToList();
        }
    }
}
