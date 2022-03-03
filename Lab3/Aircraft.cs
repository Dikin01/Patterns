using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Aircraft : AircraftDivision, IBaggagesReport
    {
        public List<AircraftDivision> AircraftDivisions { protected set; get; }
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
            for(int i = 0; i < FirstClass.PersonLimit; i++)
            {
                firstClass.Add()
            }
            BusinessClass businessClass = new BusinessClass();
            EconomyClass economyClass = new EconomyClass();

            AircraftDivisions.Add(firstClass);
            AircraftDivisions.Add(businessClass);
            AircraftDivisions.Add(economyClass);
            






        }

        public override void PutOnPlane(AircraftDivision division)
        {
            throw new NotImplementedException();
        }

        public string ReportBaggages()
        {
            return "";
        }
    }
}
