using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class BoardPizza : BoardAnyCar
    {
        public TypeLicense License { private set; get; }
        public int LimitPassenger { private set; get; }

        public BoardPizza()
        {
            Driver = new PizzaDriver();
            License = TypeLicense.A;
            LimitPassenger = 3;
            
            Passengers = new List<Passenger>();

            for (int i = 0; i < LimitPassenger; i++)
            {
                Passengers.Add(new PizzaPassenger());
                
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
