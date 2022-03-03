using System.Collections.Generic;

namespace Lab3
{
    internal class BusinessClass : AircraftClass, IBaggagesReport, IPassangerBaggageChecker
    {
        public new const int PersonLimit = 20;

        public BusinessClass()
        {
            Divisions = new List<AircraftDivision>();
        }

        public bool Check(Passenger passenger)
        {
            return passenger.Baggage.Weight < 35;
        }

        public override void PutOnPlane(AircraftDivision division)
        {
            foreach (AircraftDivision div in Divisions)
            {
                div.PutOnPlane(this);
            }
        }

        public string ReportBaggages()
        {
            string result = "\tБизнес класс:";
            for(int i = 0; i < Divisions.Count; i++)
            {
                if (Divisions[i] is Passenger)
                {
                    Passenger passenger = (Passenger) Divisions[i];
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

    }
}
