using MakeMyDayServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeMyDayServer.Services
{
    public static class Auth
    {
        private static List<Token> TokenList = new List<Token>();

        public static Token GenerateToken()
        {
            Token generatedToken;
            do {
                generatedToken = new Token();
            } while (TokenList.Contains(generatedToken));
            return generatedToken;
        }
        
        public static bool CheckTokenValidAndReneweExpirationTime(Token token)
        {
            if(TokenList.Contains(token) && token.CheckExpirationTime())
            {
                token.RenowExpirationTime();
                return true;
            }
            return false;
        }

    }
}
