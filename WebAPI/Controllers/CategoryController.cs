using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category(){ id=1, code=500, name="Computer", desc="PC, Laptop, Tablet, Phone etc." },
            new Category(){ id=2, code=600, name="Fruit", desc="All exotic fruits." },
            new Category(){ id=3, code=700, name="Clothes", desc="My clothes.." },
            new Category(){ id=4, code=800, name="Pencil", desc="My daughter's pencils.." }
        };

        // GET: api/Category
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        // GET: api/Category/5
        public Category Get(int id)
        {
            return categories.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Category
        public void Post([FromBody]Category value)
        {
            categories.Add(value);
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]Category value)
        {
            categories.Where(x => x.id == id).Select(x => { return value; }).ToList();
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
            categories.RemoveAll(x => x.id == id);
        }
    }
}
