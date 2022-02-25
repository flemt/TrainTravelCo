using System;


namespace TrainTravelCo.Models
{
    public class Train
    {
        private int _regNr;
        private static int _id = 0;
        public int RegNr { get; init; }
        //public Guid Id {  get; init; }
        public int Id { get; init; }

        public int Seats {  get; set; }


        public Train(int seats)
        {
            RegNr = 0;
            Id = _id;
            _id++;
            Seats = seats;
        }



    }
}
