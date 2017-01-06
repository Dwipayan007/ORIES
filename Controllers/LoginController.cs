using Ores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ores.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/devLogin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/devLogin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/devLogin
        public string Post(Login login)
        {

            return dbutility.getLoginData(login);
        }

        // PUT: api/devLogin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/devLogin/5
        public void Delete(int id)
        {
        }
    }
}
