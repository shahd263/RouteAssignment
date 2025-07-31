using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Question02
{

    enum Role {
        Admin,
        Student
    }
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

       
    }
}
