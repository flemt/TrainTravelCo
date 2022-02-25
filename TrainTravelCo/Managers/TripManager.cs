using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TrainTravelCo.Managers
{
    public class TripManager
    {

        Data.DataStore trainData = Data.DataStore.Instance;

        public List<Models.Trip> GetAllTrips()
        {
            return trainData.GetAllTrips();
        }
        public List<Models.TripDTO> GetAllTripsDTO()
        {
            return trainData.GetAllTripsDTO();
        }


        public void AddTrip(Models.Trip newTrip)
        {
            trainData.AddTrip(newTrip);
        }
        public void CreateTrip(Models.TripDTO inputedTrip)
        {
            try
            {
                var theTrain = trainData.GetAllTrains().Find(x => x.Id.Equals(inputedTrip.TrainId));
                var newTrip = new Models.Trip
                {
                    Start = inputedTrip.Start,
                    End = inputedTrip.End,
                    dateTime = inputedTrip.dateTime,
                    theTripsTrain = theTrain

                };
                trainData.AddTrip(newTrip);
                trainData.AddTripDTO(inputedTrip);
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
