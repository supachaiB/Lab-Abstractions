using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_and_System_Design
{
    internal class Member
    {
        private string _name;
        private string _SSID;

        public Member(string name, string SSID)
        {
            _name = name;
            _SSID = SSID;
        }
    }
}
