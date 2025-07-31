using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Question02
{
    internal interface IAuthenticationService
    {
         bool AuthenticateUser(string username, string pass);
         bool AuthorizeUser(string username, Role role);


    }
}
