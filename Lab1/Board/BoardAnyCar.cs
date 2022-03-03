using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class BoardAnyCar
    {
        public Driver Driver { protected set; get; }
        public List<Passenger> Passengers { protected set; get; }
        protected abstract bool BoardPassenger();
        protected abstract bool BoardDriver();
        public bool isMoving()
        {
            return BoardDriver()&&BoardPassenger();
        }
    }
}
