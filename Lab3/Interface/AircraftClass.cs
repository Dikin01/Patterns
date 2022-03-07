using System.Collections.Generic;

namespace Lab3
{
    internal abstract class AircraftClass : AircraftDivision, IBaggagesReport
    {
        public List<AircraftDivision> Divisions { get; protected set; }
        public const int PersonLimit = 100;
        public virtual void Add(AircraftDivision division)
        {
            if (Divisions.Count < PersonLimit)
                Divisions.Add(division);
        }
        public virtual void Remove(AircraftDivision division)
        {
            Divisions.Remove(division);
        }

        public string ReportBaggages()
        {
            string result = "Информация по багажам рейса:";
            for (int i = 0; i < Divisions.Count; i++)
            {
                if (Divisions[i] is Passenger)
                {
                    Passenger passenger = (Passenger)Divisions[i];
                    string bagStatus = passenger.Baggage.StateBaggage switch
                    {
                        StateBaggage.NotRegistered => "не прошёл регистрацию",
                        StateBaggage.OnBoard => "на борту",
                        StateBaggage.RemoveFromFlight => "снят с рейса",
                        _ => "нет информации по багажу"

                    };

                    result += $"\n\tУ пассажира {passenger.Name} + {passenger.LastName} + багаж {bagStatus}";
                }
                else if (Divisions[i] is IBaggagesReport)
                    result += (Divisions[i] as IBaggagesReport).ReportBaggages();
            }
            return result;
        }

        public virtual void RemovePassengersWithoutBaggage()
        {
            foreach (var division in Divisions.ToArray())
            {
                if (division is Passenger && (division as Passenger).Baggage.StateBaggage.Equals(StateBaggage.RemoveFromFlight))
                {
                    Divisions.Remove(division);
                }
            }
        }

    }
}
