using System.Collections.Generic;

namespace Lab2
{
    internal class BusBuilder : BoardBuilder
    {
        private BoardBus bus;

        public override void CreatBoard()
        {
            bus = new BoardBus();
        }

        public override void AddDriver()
        {
            bus.Driver = new BusDriver();
        }

        public override void AddPassenger()
        {
            bus.Passengers = new List<Passenger>();

            for (int i = 0; i < bus.LimitPassenger / 3; i++)
            {
                bus.Passengers.Add(new AdultPassenger());
                bus.Passengers.Add(new ChildPassenger());
                bus.Passengers.Add(new PrivilegedPassenger());
            }
        }

        public override BoardAnyCar GetBoard()
        {
            return bus;
        }
    }
}
