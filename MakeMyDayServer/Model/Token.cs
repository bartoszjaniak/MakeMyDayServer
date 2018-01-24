using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeMyDayServer.Model
{
    public class Token
    {
        public Guid Value { get; private set; }
        public DateTime DeadTime { get; private set; }

        public Token()
        {
            if(Value == null)
            {
                Value = Guid.NewGuid();
                DeadTime = DateTime.Now.AddMinutes(20);
            }           
        }

        public bool CheckExpirationTime()
        {
            if (DeadTime > DateTime.Now)
                return true;            
            else
                return false;
        }
    }
}
