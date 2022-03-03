namespace Lab1
{
    public class TaxiPassenger:Passenger
    {
        public MaturityPassenger Maturity { get; protected set; }
        public bool OnCarSeat { get; set; }
        public TaxiPassenger(string name = "Иван", MaturityPassenger maturity = MaturityPassenger.Adult) : base(name)
        {
            Maturity = maturity;
        }

    }
}
