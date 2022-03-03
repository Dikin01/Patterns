namespace Lab1
{
    public class BusPassenger : Passenger
    {
        public MaturityPassenger Maturity { protected set; get; }
        public BusPassenger(string name = "Иван", MaturityPassenger maturity = MaturityPassenger.Adult) : base(name)
        {
            Maturity = maturity;
        }
    }
}
