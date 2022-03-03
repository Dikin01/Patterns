namespace Lab3
{
    internal abstract class AircraftPerson : AircraftDivision
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public AircraftPerson(string name = "Иван", string lastName = "Иванов")
        {
            Name = name;
            LastName = lastName;
        }
        
    }
}
