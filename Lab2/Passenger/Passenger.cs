using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Passenger
    {
        public string Name { protected set; get; }
        public bool IsWantTaxi { protected set; get; }
       

        public Passenger(string name = "Иван", bool isWantTaxi = true)
        {
            Name = name;
            IsWantTaxi = isWantTaxi;
            
        }
    }
}
