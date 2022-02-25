using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        Data.DataStore trainData = Data.DataStore.Instance;

        public List<Models.Train> GetAllTrains()
        {
            return trainData.GetAllTrains();    
        }
        public void AddTrain(Models.Train newTrain)
        {
            trainData.AddTrain(newTrain);
        }

    }
}
