using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BusDriver:Driver
    {
        public BusDriver(string name = "Иван", string lastName = "Иванов", string lisence = "Bus")
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
