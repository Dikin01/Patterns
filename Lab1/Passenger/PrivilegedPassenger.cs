using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class PrivilegedPassenger:Passenger
    {
        public bool HasTravelCard { protected set; get; }

        public PrivilegedPassenger(string name = "Иван", bool isWantTaxi = true, bool hasTravelCard = true):base(name, isWantTaxi)
        {
            HasTravelCard = hasTravelCard;
        }
    }
}
