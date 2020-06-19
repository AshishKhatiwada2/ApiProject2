using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject2.Controllers
{
    [RoutePrefix("api/products")]

    public class ProductsController : ApiController
    {
        // GET: api/Products
        [HttpGet, Route("")]
        public IEnumerable<string> SelectAllProducts()
        {
            return new string[] { "product1 ", "product2" };
        }

        // GET: api/Products/5
        [HttpGet,Route("{id}/orders/{custid}")]
        public string Get(int id,string custid)
        {
            return "product id = "+id+"custid = "+custid ;
        }

        // POST: api/Products
        [HttpPost,Route("{id}")]
        public void CreateProduct([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut,Route("{id}")]
        public string Put(int id, [FromBody]string value)
        {
            return "returned current person id =" + id + " " + value;
        }

        // DELETE: api/Products/5
        [HttpDelete,Route("{id}")]
        public string Delete(int id)
        {
            return "deleted value id= " + id;
        }
    }
}
