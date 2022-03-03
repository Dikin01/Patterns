using System.Collections.Generic;

namespace Lab1
{
    public abstract class BoardAnyCar
    {
        public Driver Driver { set; get; }
        public List<Passenger> Passengers { set; get; }
        protected abstract bool BoardPassenger();
        protected abstract bool BoardDriver();
        public bool isMoving()
        {
            return BoardDriver()&&BoardPassenger();
        }
    }
}
