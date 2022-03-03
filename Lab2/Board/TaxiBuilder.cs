using System.Collections.Generic;

namespace Lab2
{
    internal class TaxiBuilder : BoardBuilder
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
                taxi.Passengers.Add(new AdultPassenger());
            }
            taxi.Passengers.Add(new ChildPassenger());
            taxi.hasChildSeat = true;
        }

        public override BoardAnyCar GetBoard()
        {
            return taxi;
        }
    }
}
