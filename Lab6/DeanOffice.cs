using System;
using System.Collections.Generic;

namespace Lab6
{
    public class DeanOffice : IObservable
    {
        List<IObserver> obsevers = new List<IObserver>();
        public event Func<string> CollectReport;

        public string NextWeek()
        {
            string result = CollectReport?.Invoke();
            return result.Equals("") ? "Все вовремя сдали успеваемость" : result;            
        }
    }
}
