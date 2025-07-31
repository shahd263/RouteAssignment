using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>
        {
            {"Shahd" , new User(){Username = "Shahd", Password = "123456" , Role = Role.Admin } },
            {"Omar" , new User(){Username = "Omar", Password = "2607" , Role = Role.Student } }
        };
       
        public bool AuthenticateUser(string username, string pass)
        {
            return users.ContainsKey(username) && users[username].Password==pass;
        }

        public bool AuthorizeUser(string username, Role role)
        {
            return users.ContainsKey(username) && users[username].Role == role ;
        }
    }
}
