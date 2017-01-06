using Ores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ores.Controllers
{
    public class devSignupController : ApiController
    {
        // GET: api/devSignup
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/devSignup/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/devSignup
        public bool Post(Developer developer)
        {
            bool res = false;
            return res = dbutility.developerSignup(developer);
        }

        // PUT: api/devSignup/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/devSignup/5
        public void Delete(int id)
        {
        }
    }
}
