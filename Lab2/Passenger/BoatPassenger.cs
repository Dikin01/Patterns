namespace Lab2
{
    public class BoatPassenger : Passenger
    {
        public bool HasLifeJacket { get; set; }

        public BoatPassenger(string name = "Иван", bool hasLifeJacket = false) : base(name)
        {
            HasLifeJacket = hasLifeJacket;
        }
    }
}
