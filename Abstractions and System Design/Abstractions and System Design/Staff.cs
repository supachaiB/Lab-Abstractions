using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_and_System_Design
{
    internal class Staff
    {
        private string _username;
        private string _password;

        public Staff(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        public bool login(string username, string password)
        {
            
        }
    }

}
