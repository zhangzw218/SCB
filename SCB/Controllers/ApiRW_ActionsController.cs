using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SCB.Controllers
{
    public class ApiRW_ActionsController : ApiController
    {
        // GET: api/ApiRW_Actions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiRW_Actions/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ApiRW_Actions
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ApiRW_Actions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiRW_Actions/5
        public void Delete(int id)
        {
        }
    }
}
