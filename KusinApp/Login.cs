using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusinApp
{
    internal class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public DateTime LoginTime { get; set; }

        public Login()
        {
            LoginTime = DateTime.Now;
        }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
            LoginTime = DateTime.Now;
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Password);
        }
    }
}