using System;
using System.Collections.Generic;

namespace Lab6
{
    public class DeanOffice : IObservable
    {
        //Notify в гофе
        public event Func<string> CollectReport;

        //Расширенный Notify, для диаграмки в метод запихнут
        public string NextWeek()
        {
            string result = CollectReport?.Invoke();
            return result.Equals("") ? "Все вовремя сдали успеваемость" : result;            
        }
    }
}
