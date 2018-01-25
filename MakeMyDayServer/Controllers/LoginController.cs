using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MakeMyDayServer.Model;
using MakeMyDayServer.Services;

namespace MakeMyDayServer.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET api/values
        [HttpGet]
        public int Get()
        {

            return SesionAuth.AcctualUserCount();
        }


        [HttpGet("{id}")]
        public string Get(Guid id, [FromBody] string value)
        {
            return id.ToString() ;
        }

        // POST api/values   -- zakładanie konta
        [HttpPost]
        public string Post([FromBody]string value)
        {
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Account value)
        {
        
            bool userValid = value.LoginValid();

            if (userValid)
                return "Zalogowano Token: " + SesionAuth.GetNewToken();
            else
                return "Błędne dane logowania";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}