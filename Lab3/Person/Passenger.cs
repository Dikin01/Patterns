namespace Lab3
{
    internal class Passenger : AircraftPerson, ICarryBaggage
    {
        private Baggage baggage;
        //private double weightBaggageLimit = 20;

        public Baggage Baggage
        {
            get => baggage;
        }        

        public Passenger(Baggage baggage, string name = "Иван", string lastName = "Иванов") : base(name, lastName)
        {
            this.baggage = baggage;            
        }

        public override void PutOnPlane(AircraftDivision division)
        {
            if (division is IPassangerBaggageChecker && (division as IPassangerBaggageChecker).Check(this))
            {
                baggage.StateBaggage = StateBaggage.RemoveFromFlight;
            }
            else
            {
                baggage.StateBaggage = StateBaggage.OnBoard;
            }
        }
    }
}
