using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BoardTaxi:BoardAnyCar
    {
        public TypeLicense License { private set; get; }
        public int LimitPassenger { private set; get; }
        public double Price { private set; get; }
        public BoardTaxi()
        {
            License = TypeLicense.B;
            Price = 150;
            LimitPassenger = 4;
            Passengers = new List<Passenger>();

            Driver = new TaxiDriver();
            
            for (int i = 0; i < LimitPassenger; i++)
            {
                Passengers.Add(new AdultPassenger());
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

            
            return true;
        }
    }
}
