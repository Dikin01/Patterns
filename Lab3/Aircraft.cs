using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Aircraft : AircraftDivision, IBaggagesReport
    {
        public List<AircraftDivision> Divisions { set; get; }
        private Pilot[] pilots = new Pilot[2];
        private Stewardess[] stewardesses = new Stewardess[6];


        public double BaggageWeightLimit { get; protected set; }

        public Aircraft(double baggageWeightLimit = 1800)
        {
            BaggageWeightLimit = baggageWeightLimit < 1800 ? 1800 : baggageWeightLimit;

            for(int i = 0; i < pilots.Length; i++)
            {
                pilots[i] = new Pilot();
            }
            for (int i = 0; i < stewardesses.Length; i++)
            {
                stewardesses[i] = new Stewardess();
            }


            FirstClass firstClass = new FirstClass();
            EconomyClass economyClass = new EconomyClass();
            BusinessClass businessClass = new BusinessClass();

            for(int i = 0; i < FirstClass.PersonLimit; i++)

            {
                firstClass.Add(GetRandomPassenger());
            }
            for (int i = 0; i < EconomyClass.PersonLimit; i++)
            {
                economyClass.Add(GetRandomPassenger());
            }
            for(int i = 0; i<BusinessClass.PersonLimit; i++)
            {
                businessClass.Add(GetRandomPassenger());
            }

            Divisions = new List<AircraftDivision>();
            Divisions.Add(firstClass);
            Divisions.Add(businessClass);
            Divisions.Add(economyClass);
        }

        
        public override void PutOnPlane(AircraftDivision division)
        {
            for(int i = 0; i<Divisions.Count(); i++)
            {
                Divisions[i].PutOnPlane(this);
            }
        }

        public string ReportBaggages()
        {
            string result = "Посадка багажа на самолёт";
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
            return result; ;
        }

        private Passenger GetRandomPassenger()
        {
            return new Passenger(new Baggage(new Random().Next(0, 45)));
        }
    }
}
