namespace Lab2
{
    public class BoardTaxi:BoardAnyCar
    {
        public TypeLicense License { private set; get; }
        public int LimitPassenger { private set; get; }
        public double Price { private set; get; }
        
        public BoardTaxi()
        {
            License = TypeLicense.B;
            Price = 150;
            LimitPassenger = 4;            
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

            foreach (TaxiPassenger passenger in Passengers)
            {
                if(passenger.Maturity.Equals(MaturityPassenger.Kid) && passenger.OnCarSeat == false)
                    return false;
            }
                
            return true;
        }
    }
}
