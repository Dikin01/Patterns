using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class TaxiDriver:Driver
    {
        public TaxiDriver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.B)
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
