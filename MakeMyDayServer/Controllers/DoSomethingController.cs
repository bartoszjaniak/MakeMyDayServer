using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MakeMyDayServer.Services;

namespace MakeMyDayServer.Controllers
{
    [Produces("application/json")]
    [Route("api/DoSomething")]
    public class DoSomethingController : Controller
    {
        // GET: api/DoSomething
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DoSomething/5
        [HttpGet("{token}")]
        public string Get(string token)
        {
            if (SesionAuth.CheckTokenValidAndReneweExpirationTime(new Model.Token(token)))
                return "do";
            else
                return "not do";
        }
        
        // POST: api/DoSomething
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/DoSomething/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
