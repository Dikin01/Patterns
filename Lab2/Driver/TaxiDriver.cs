namespace Lab2
{
    public class TaxiDriver:Driver
    {
        public TaxiDriver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.B)
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
