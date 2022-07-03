using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AirlineReservation1.Models;

namespace AirlineReservation1.Models
{
    public class FlightVM
    {
        public int FlightID { get; set; }
        public string Email { get; set; }
        public int ClassID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int NoofTickets { get; set; }
        public int BookingAmount { get; set; }
        public System.DateTime DateOfDeparture { get; set; }
        public Nullable<System.DateTime>  ReturnDate { get; set; }
        public Nullable<System.Boolean>  ReturnTicket { get; set; } 
        public int SeatID { get; set; }
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


    }
}