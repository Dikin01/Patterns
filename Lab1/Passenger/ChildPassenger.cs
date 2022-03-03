using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ChildPassenger : Passenger
    {
        public int Age { private set; get; }
        public ChildPassenger(string name = "Иван", bool isWantTaxi = true, int age = 5) : base(name, isWantTaxi)
        {
            Age = age;
        }
    }
}
