using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ores.Controllers
{
    public class memberLoginController : ApiController
    {
        // GET: api/memberLogin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/memberLogin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/memberLogin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/memberLogin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/memberLogin/5
        public void Delete(int id)
        {
        }
    }
}
