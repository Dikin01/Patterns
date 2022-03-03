namespace Lab1
{
    public class TaxiDriver : Driver
    {
        public TaxiDriver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.B)
            : base(name, lastName, lisence) { }
        
    }
}
