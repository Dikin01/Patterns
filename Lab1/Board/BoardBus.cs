using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BoardBus : BoardAnyCar
    {
        public string License { private set; get; }
        public int LimitPassenger { private set; get; }
        public double Price { private set; get; }
        public BoardBus()
        {
            Driver = new BusDriver();
            License = "Bus";
            LimitPassenger = 30;
            Price = 34;
            Passengers = new List<Passenger>();

            for (int i = 0; i < LimitPassenger/3; i++)
            {
                Passengers.Add(new AdultPassenger());
                Passengers.Add(new ChildPassenger());
                Passengers.Add(new PrivilegedPassenger());
            }
        }

        protected override bool BoardDriver()
        {
            if (Driver == null || !Driver.Lisence.Equals(License))
            {
                return false;
            }
            return true;
        }

        protected override bool BoardPassenger()
        {

            if (Passengers.Count > LimitPassenger)
            {
                return false;
            }


            foreach (Passenger p in Passengers)
            {
                if (p is PrivilegedPassenger && !(p as PrivilegedPassenger).HasTravelCard)
                {
                    return false;
                }
                if (p is ChildPassenger && !((p as ChildPassenger).Age < 8))
                {
                    return false;
                }

            }


            return true;
        }
    }
}
