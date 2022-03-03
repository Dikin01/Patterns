using System.Collections.Generic;

namespace Lab2
{
    public class BusBuilder : BoardBuilder
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

            for (int i = 0; i < bus.LimitPassenger / 2; i++)
            {
                bus.Passengers.Add(new BusPassenger());
                bus.Passengers.Add(new BusPassenger("Ванька", MaturityPassenger.Kid));
            }
        }

        public override BoardAnyCar GetBoard()
        {
            return bus;
        }

        public override void ProtectPassengers()
        {
            return;
        }
    }
}
