using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private Managers.BookingManager manager;

        public BookingController()
        {
            manager = new Managers.BookingManager();
        }
        [HttpGet("search")]
        public IActionResult Search(string dateTime)
        {
            try
            {
                

                return Ok(manager.Search(dateTime));
            }
            catch (Exception)
            {
                return NotFound();

            }

        }
        [HttpPost("BookTrip")]
        public IActionResult BookTrip(Models.Customer customer,[FromQuery]int tripId)
        {
            Models.Customer customer1 = new Models.Customer
            {
                _name = customer._name,
                _phoneNummber = customer._phoneNummber,
            };
            manager.BookTrip(tripId, customer1);
            return Ok();
        }
    }
}
