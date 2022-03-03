using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BusDriver:Driver
    {
        public BusDriver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.D)
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
