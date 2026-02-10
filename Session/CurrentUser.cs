using Govt.BDPension.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govt.BDPension.Session
{
    public static class CurrentUser
    {
        public static UserRole? Role { get; set; }
        public static string Username { get; set; }
    }
}
