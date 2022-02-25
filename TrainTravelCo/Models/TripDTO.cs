
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TrainTravelCo.Models
{
    public class TripDTO
    {
        [Required]
        public string Start { get; set; }
        [Required]
        public string End { get; set; }
        [Required]
        public string dateTime { get; set; }
        [Required]
        public int TrainId { get; set; }

        public List<BookingDTO> BookingHistory { get; set; }

    }
}
