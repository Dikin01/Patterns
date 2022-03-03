namespace Lab2
{
    public class BoatBoard : BoardAnyCar
    {
        public int LimitPassenger { private set; get; }
        
        public BoatBoard()
        {
            LimitPassenger = 6;
        }

        protected override bool BoardDriver()
        {
            if (Driver == null)
            {
                return false;
            }

            return true; ;
        }

        protected override bool BoardPassenger()
        {
            if (Passengers.Count > LimitPassenger)
            {
                return false;
            }

            foreach (var passenger in Passengers)
                if ((passenger as BoatPassenger).HasLifeJacket == false)
                    return false;

            return true; ;
        }
    }

    public class CopyOfBoatBoard : BoardAnyCar
    {
        public int LimitPassenger { private set; get; }

        public CopyOfBoatBoard()
        {
            LimitPassenger = 6;
        }

        protected override bool BoardDriver()
        {
            if (Driver == null)
            {
                return false;
            }

            return true; ;
        }

        protected override bool BoardPassenger()
        {
            if (Passengers.Count > LimitPassenger)
            {
                return false;
            }

            foreach (var passenger in Passengers)
                if ((passenger as BoatPassenger).HasLifeJacket == false)
                    return false;

            return true; ;
        }
    }
}
