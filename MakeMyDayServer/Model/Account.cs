using MakeMyDayServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeMyDayServer.Model
{
    public class Account
    {
        public enum CreateStatus
        {
            OK,
            EXISTS,
            ERROR
        };

        public string Login { get; }
        public string Password { get; }
        public string SuperToken { get; }
        

        //public CreateStatus Account(string login, string password)
        //{
        //    Login = login;
        //    Password = password;
        //    SuperToken = GenerateSuperToken();

        //    return CreateStatus.OK;
        //}

        private string GenerateSuperToken()
        {
            return Guid.NewGuid().ToString();
        }

        public bool LoginValid()
        {
            //TODO: check in database if user is exists and check password
            return true;
        }     
    }
}
