using AirlineReservation1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlineReservation1.Models
{
    public class Login
    {
        public string UserName { set; get; }
        public string Password { set; get; }
    }
    public class Registration : RegisteredUser { }
    public class AddFlight : Flight { }
    public class AddClass : Class { }


}