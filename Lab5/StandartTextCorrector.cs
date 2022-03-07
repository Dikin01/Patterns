using System.Collections.Generic;

namespace Lab5
{
    internal class StandartTextCorrector : ITextCorrector
    {
        protected List<ITextCorrector> correctors;

        public StandartTextCorrector()
        {
            correctors = new List<ITextCorrector>();

            correctors.Add(new MultSpacesCorrector());
            correctors.Add(new DashesCorrector());
            correctors.Add(new QuotesCorrector());
            correctors.Add(new TabCorrector());
            correctors.Add(new SeparationCorrector());
            correctors.Add(new BreakCorrector());


        }

        public string Correct(string text)
        {
            foreach (ITextCorrector corrector in correctors)
            {
                text = corrector.Correct(text);
            }
            return text;
        }
    }
}
