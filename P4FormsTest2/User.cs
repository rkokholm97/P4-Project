using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4FormsTest2
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public User(string username, string password, string firstname, string lastname)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
