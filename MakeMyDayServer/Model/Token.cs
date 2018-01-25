﻿using MakeMyDayServer.Settings;
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
            Value = System.Guid.NewGuid();
            DeadTime = DateTime.Now.AddSeconds(SessionProperties.SessionTimeInSecound);
         } 

        public Token(Guid token)
        {
            Value = token;
            DeadTime = DateTime.Now.AddSeconds(SessionProperties.SessionTimeInSecound);
        }

        public Token(string token)
        {
            Value = Guid.Parse(token);
            DeadTime = DateTime.Now.AddSeconds(SessionProperties.SessionTimeInSecound);
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
            DeadTime = DateTime.Now.AddSeconds(SessionProperties.SessionTimeInSecound);
        }

        public override bool Equals(object obj)
        {
            return ((Token)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Value.GetHashCode();
            hash = (hash * 7) + DeadTime.GetHashCode();
            return hash;            
        }

        public override string ToString()
        {
            return Value.ToString();
        }               
    }
}
