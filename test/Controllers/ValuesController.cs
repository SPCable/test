using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test.Models;

namespace test.Controllers
{
    public class ValuesController : ApiController
    {
        List<Product> products = Product.products;
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return Product.products;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values/
        public void Post([FromBody] Product product)
        {
            Product product1 = new Product() { id = "5", name = "haha", categoryId = "tb", status = true };
            products.Add(product1);
        }

        // PUT api/values/5
        public void Put(string id, [FromBody] Product product)
        {

            List<Product> products = Product.products;

            foreach(var p in products)
            {
                if(p.id == id)
                {
                    p.status = true;
                }
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
