using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public class BoatBuilder : BoardBuilder
    {
        private BoatBoard boat;

        public override void AddDriver()
        {
            boat.Driver = new BoatDriver();
        }

        public override void AddPassenger()
        {
            boat.Passengers = new List<Passenger>();

            for (int i = 0; i < boat.LimitPassenger; i++)
            {
                boat.Passengers.Add(new BoatPassenger());                
            }
        }

        public override void CreatBoard()
        {
            boat = new BoatBoard();
        }

        public override BoardAnyCar GetBoard()
        {
            return boat;
        }

        public override void ProtectPassengers()
        {
            for (int i = 0; i < boat.Passengers.Count(); i++)
            {
                BoatPassenger passenger = (BoatPassenger) boat.Passengers[i];
                passenger.HasLifeJacket = true;
            };
        }
    }
}
