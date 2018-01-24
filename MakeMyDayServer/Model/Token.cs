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

        public void RenowExpirationTime()
        {
            DeadTime = DateTime.Now.AddMinutes(20);
        }

        public override bool Equals(object obj)
        {
            return ((Token)obj).Value == Value && ((Token)obj).DeadTime == DeadTime;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Value.GetHashCode();
            hash = (hash * 7) + DeadTime.GetHashCode();
            return hash;            
        }
    }
}
