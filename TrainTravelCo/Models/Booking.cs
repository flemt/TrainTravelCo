
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Booking
    {
        public Customer Customer { get; set; }
        public Trip Trip { get; set; }
    }
}
