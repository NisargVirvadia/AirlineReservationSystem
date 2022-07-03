using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AirlineReservation1.Models;

namespace AirlineReservation1.Controllers
{
    public class BookingController : ApiController
    {
        FRSEntities db = new FRSEntities();

        /*[HttpPost]
        public IHttpActionResult Booking(FlightVM booking)
        {
            Booking booking1 = new Booking();
            Passenger passenger = new Passenger();
            booking1.ClassID = booking.ClassID;
            booking1.FlightID = booking.FlightID;
            booking1.Email = booking.Email;
            booking1.BookingDate = booking.BookingDate;
            booking1.NoofTickets = booking.NoofTickets;
            booking1.BookingAmount = booking.BookingAmount;
            booking1.DateOfDeparture = booking.DateOfDeparture;
            booking1.ReturnDate = booking.ReturnDate;
            booking1.ReturnTicket = Convert.ToBoolean(booking.ReturnTicket);
            



            

        }*/


    }
}
