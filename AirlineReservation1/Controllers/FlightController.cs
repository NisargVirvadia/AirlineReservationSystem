using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AirlineReservation1.Models;


namespace AirlineReservation.Controllers
{
    public class FlightController : ApiController
    {
        FRSEntities db = new FRSEntities();

        [Route("GetFlight")]
        public HttpResponseMessage Get()
        {
            var flight = db.Flights.ToList();
            if (flight.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, flight);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No data");


            }
        }


        [Route("Api/AddFlight")]
        [HttpPost]
        public object createflight(AddFlight Lvm)
        {
            try
            {
                FRSEntities db = new FRSEntities();
                Flight Ru = new Flight();
                if (Ru.FlightID == 0)
                {

                    Ru.SourceFlight = Lvm.SourceFlight;
                    Ru.Destination = Lvm.Destination;
                    Ru.ArrivalTime = Lvm.ArrivalTime;
                    Ru.DepartureTime = Lvm.DepartureTime;
                    Ru.NoOfSeats = Lvm.NoOfSeats;
                    Ru.FlightDate = Lvm.FlightDate;
                    Ru.Duration = Lvm.Duration;
                    db.Flights.Add(Ru);
                    db.SaveChanges();
                    return new Response
                    { Status = "Success", Message = "SuccessFully Saved.",FlightID=Ru.FlightID };
                }
            }
            catch (Exception)
            {

                throw;
            }
            return new Response
            { Status = "Error", Message = "Invalid Data." };
        }

        [Route("RemoveFile")]
        [ResponseType(typeof(Flight))]
        public HttpResponseMessage Delete(int id)
        {
            FRSEntities db = new FRSEntities();
            try
            {
                Flight flight = db.Flights.Where(q => q.FlightID == id).FirstOrDefault();
                flight.Del = 0;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Successful Deletion");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Unsuccessful");
            }
        }

    }

  

    /*public IHttpActionResult GetNoOfSeats(int id)
    {
        Flight flight = db.flights.Find(p => p.Id == id);
        return Ok(flight);
    }*/
}
