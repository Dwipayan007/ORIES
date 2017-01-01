using Ores.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Ores.Controllers
{
    public class memberSignupController : ApiController
    {
        // GET: api/memberSignup
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/memberSignup/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/memberSignup
        public bool Post(Member member)
        {
            bool res = false;
            return res= dbutility.memberSignup(member);
        }

        // PUT: api/memberSignup/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/memberSignup/5
        public void Delete(int id)
        {
        }
    }
}
