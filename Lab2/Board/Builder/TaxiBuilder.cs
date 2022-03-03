using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public class TaxiBuilder : BoardBuilder
    {
        private BoardTaxi taxi;

        public override void CreatBoard()
        {
            taxi = new BoardTaxi();
        }

        public override void AddDriver()
        {
            taxi.Driver = new TaxiDriver();
        }

        public override void AddPassenger()
        {
            taxi.Passengers = new List<Passenger>();
            for (int i = 0; i < taxi.LimitPassenger-1; i++)
            {
                taxi.Passengers.Add(new TaxiPassenger());
            }
            taxi.Passengers.Add(new TaxiPassenger("Ванька", MaturityPassenger.Kid));
            
        }

        public override BoardAnyCar GetBoard()
        {
            return taxi;
        }

        public override void ProtectPassengers()
        {
            for(int i = 0; i < taxi.Passengers.Count(); i++)
            {
                TaxiPassenger passenger = (TaxiPassenger) taxi.Passengers[i];
                if (passenger.Maturity.Equals(MaturityPassenger.Kid))
                {
                    passenger.OnCarSeat = true;
                }
            }
        }
    }
}
