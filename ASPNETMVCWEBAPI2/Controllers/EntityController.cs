using System.Collections.Generic;
using System.Web.Http;

namespace ASPNETMVCWEBAPI2.Controllers
{
    public class EntityController : ApiController
    {
        // GET: api/Entity
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Entity/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Entity
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Entity/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Entity/5
        public void Delete(int id)
        {
        }
    }
}
