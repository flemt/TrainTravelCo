using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TrainTravelCo.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private Managers.TrainManager manager;

        public TrainController()
        {
            manager = new Managers.TrainManager();
        }

        [HttpGet("List")]
        public IActionResult GetList()
        {
            
            return Ok(manager.GetAllTrains());
        }

        [HttpPost]
        public IActionResult AddTrain(Models.Train newTrain)
        {
            manager.AddTrain(newTrain);
            return Ok();    
        }
    }
}
