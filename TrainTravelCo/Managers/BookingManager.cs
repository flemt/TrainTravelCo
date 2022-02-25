using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Managers
{
    public class BookingManager
    {
        Data.DataStore trainData = Data.DataStore.Instance;
        public BookingManager()
        {


        }
        public List<Models.TripDTO> Search(string dateTime)
        {
            //try
            //{
            List<Models.TripDTO> trips = new List<Models.TripDTO>();
            foreach (var item in trainData.GetAllTrips())
            {
                if (item.dateTime == dateTime && item.BookingHistory.Count <= item.theTripsTrain.Seats)
                {
                    trips.Add(trainData.TripToDTO(item));
                }
            }
                //trainData.GetAllTrips();
            //trips = trips.FindAll(x => x.Start == start);
            return trips;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }
        public void BookTrip(int tripId,Models.Customer customer)
        {
            try
            {
                //var addCustomerToTrip = trainData.GetAllTrips().Find(x => x.TripId.Equals(tripId));

                //addCustomerToTrip.BookingHistory.Add(booking);
                Models.Trip trips = new Models.Trip();
                foreach (var item in trainData.GetAllTrips())
                {
                    if (item.TripId == tripId)
                    {
                        trips = item;
                    }
                }
                try
                {
                    if (trips.BookingHistory.Count < trips.theTripsTrain.Seats)
                    {
                        Models.Booking booking = new Models.Booking { Customer = customer, Trip = trips };
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {

                    throw;
                }
            
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
