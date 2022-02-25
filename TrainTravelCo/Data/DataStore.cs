using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private List<Models.Train> _trains = new List<Models.Train>(); 
        private List<Models.Trip> _trips= new List<Models.Trip>();
        private List<Models.TripDTO> _tripsDTO = new List<Models.TripDTO>();

        private static DataStore _instance;
        public static DataStore Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataStore();
            return _instance; 
            } 
        } 
        private DataStore()
        {
            _trains.Add(new Models.Train(2));
            _trains.Add(new Models.Train(9));
            _trains.Add(new Models.Train(34));
            _trips.Add(new Models.Trip { Start = "Örebro", End = "Stockholm", dateTime = "19.00", theTripsTrain = _trains[0]});
            _trips.Add(new Models.Trip { Start = "Malmö", End = "Stockholm", dateTime = "12.00", theTripsTrain = _trains[2] });
            _trips.Add(new Models.Trip { Start = "Saturnus", End = "Prag", dateTime = "04.00", theTripsTrain = _trains[1] });




        }
        public List<Models.Train> GetAllTrains()
        {
            return _trains;
        }
        public void AddTrain(Models.Train train)
        {
            _trains.Add(train);
        }
        public List<Models.Trip> GetAllTrips()
        {
            return _trips;
        }
        public List<Models.TripDTO> GetAllTripsDTO()
        {
            List<Models.TripDTO> result = new List<Models.TripDTO>();
            foreach (var item in _trips)
            {
                result.Add(TripToDTO(item));
            }
            return result;
        }
        public Models.TripDTO TripToDTO(Models.Trip trip)
        {
            
            List<Models.BookingDTO> converter = new List<Models.BookingDTO>();
            if (trip.BookingHistory != null)
            {
                converter = trip.ReturnBookingsDTO();
            }
            var newTripDto = new Models.TripDTO
            {
                Start = trip.Start,
                End = trip.End,
                dateTime = trip.dateTime,
                TrainId = trip.theTripsTrain.Id,
                BookingHistory = converter
            };
                return newTripDto;

        }

        public void AddTrip(Models.Trip newTrip)
        {
            _trips.Add(newTrip);
        }
        public void AddTripDTO(Models.TripDTO newTrip)
        {
            _tripsDTO.Add(newTrip);
        }
    }      

}
