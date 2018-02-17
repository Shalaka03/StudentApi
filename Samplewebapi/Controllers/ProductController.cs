using System.Collections.Generic;
using System.Web.Http;
using Samplewebapi.Models;

namespace Samplewebapi.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Product 

        List<Product> probs = new List<Product>();

        public ProductController()
            {

            }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}