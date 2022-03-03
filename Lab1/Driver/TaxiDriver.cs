using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class TaxiDriver:Driver
    {
        public TaxiDriver(string name = "Иван", string lastName = "Иванов", string lisence = "Taxi")
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
