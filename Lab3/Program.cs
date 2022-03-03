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
        }
    }
}
