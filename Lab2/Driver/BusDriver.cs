namespace Lab2
{
    public class BusDriver:Driver
    {
        public BusDriver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.D)
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }
    }
}
