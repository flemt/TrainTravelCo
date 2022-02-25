
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TrainTravelCo.Models
{
    public class Trip
    {
        public string Start {  get; set; }
        public string End {  get; set; }   
        public string dateTime {  get; set; }

        public Train theTripsTrain { get; set; }

        public List<Models.Booking> BookingHistory {  get; set; } 

        public int TripId { get; }

        public Trip()
        {
            TripId = TripID.GetId();
            BookingHistory = new List<Models.Booking>();
        }
        public Trip(Models.TripDTO safeTrip)
        {
            TripId = TripID.GetId();
            Start = safeTrip.Start;
            End = safeTrip.End;
            dateTime = safeTrip.dateTime;
        }
        public List<Models.BookingDTO> ReturnBookingsDTO()
        {
            List<Models.BookingDTO> bookingDTOs= new List<Models.BookingDTO>();
                       
                foreach (var item in BookingHistory)
                {
                    bookingDTOs.Add(new Models.BookingDTO { Customer = item.Customer });
                }
            
            return bookingDTOs;
        }

    }
}
