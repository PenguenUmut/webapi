using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {

        public static List<Product> products = new List<Product>()
        {
            new Product(){ id=101, name="Mac", desc="Very expensive computer." , price=1000.50M, stock=true, version=5, category = new Category(){ id=1, code=500, name="Computer", desc="PC, Laptop, Tablet, Phone etc." } },
            new Product(){ id=102, name="Notebook", desc="My ex laptop." , price=10.50M, stock=true, version=1, category = new Category(){  id=1, code=500, name="Computer", desc="PC, Laptop, Tablet, Phone etc." } },
            new Product(){ id=103, name="Apple", desc="an apple" , price=1.50M, stock=true, version=2, category = new Category(){ id=2, name="Fruit", desc="All exotic fruits." }},
            new Product(){ id=104, name="Pear", desc="Very big pear!" , price=2.50M, stock=true, version=2, category = new Category(){ id=2, name="Fruit", desc="All exotic fruits." }},
            new Product(){ id=105, name="Green", desc="first pencil" , price=2, stock=true, version=1, category = new Category(){ id=4, code=800, name="Pencil", desc="My daughter's pencils.." }},
        };

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return products.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Product
        public void Post([FromBody]Product value)
        {
            products.Add(value);
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]Product value)
        {
            products.Where(x => x.id == id).Select(x => { return value; }).ToList();
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            products.RemoveAll(x => x.id == id);
        }
    }
}
