namespace Lab1
{
    public abstract class Driver
    {
        public TypeLicense Lisence { protected set; get; }
        public string Name { protected set; get; }
        public string LastName { protected set; get; }

        public Driver(string name = "Иван", string lastName = "Иванов", TypeLicense lisence = TypeLicense.B)
        {
            Name = name;
            LastName = lastName;
            Lisence = lisence;
        }

    }
}
