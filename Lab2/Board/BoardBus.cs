namespace Lab2
{
    public class BoardBus : BoardAnyCar
    {
        public TypeLicense License { private set; get; }
        public int LimitPassenger { private set; get; }
        public double Price { private set; get; }
        public BoardBus()
        {
            Driver = new BusDriver();
            License = TypeLicense.D;
            LimitPassenger = 30;
            Price = 34;         
        }

        protected override bool BoardDriver()
        {
            if (Driver == null || !Driver.Lisence.Equals(License))
            {
                return false;
            }
            return true;
        }

        protected override bool BoardPassenger()
        {

            if (Passengers.Count > LimitPassenger)
            {
                return false;
            }


            foreach (Passenger p in Passengers)
            {
                if (p is PrivilegedPassenger && !(p as PrivilegedPassenger).HasTravelCard)
                {
                    return false;
                }
                if (p is ChildPassenger && !((p as ChildPassenger).Age < 8))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
