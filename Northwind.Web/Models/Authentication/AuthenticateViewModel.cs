using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Web.Models.Authentication
{    
    public class AuthenticateViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}