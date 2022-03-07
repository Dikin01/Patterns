using System;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aircraft aircraft = new Aircraft();
            aircraft.PutOnPlane(aircraft);
            
            Console.WriteLine(aircraft.ReportBaggages());
            Console.WriteLine("Высадка пассажиров без багажа");
            
            foreach (var div in aircraft.Divisions.ToArray())
            {
                if(div is BusinessClass)
                {
                    (div as BusinessClass).RemovePassengersWithoutBaggage();
                }
            }

            Console.WriteLine(aircraft.ReportBaggages());
        }
    }
}
