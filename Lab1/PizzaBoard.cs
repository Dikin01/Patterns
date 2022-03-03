using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Driver
{
    internal class PizzaBoard : BoardAnyCar
    {
        public TypeLicense License { private set; get; }
        public int LimitPassenger { private set; get; }

        public PizzaBoard()
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
            ;
        }

        protected override bool BoardPassenger()
        {
            ;
        }
    }
}
