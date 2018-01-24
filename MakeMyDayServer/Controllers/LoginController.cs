using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MakeMyDayServer.Model;

namespace MakeMyDayServer.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5  -- logowanie
        [HttpGet("{id}")]
        public string Get(Account account)
        {
            var userValid = account.TryLogin();

            if (userValid)
                return "Zalogowano";
            else
                return "Błędne dane logowania";
        }

        // POST api/values   -- zakładanie konta
        [HttpPost]
        public void Post(Account account)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}