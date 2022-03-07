using System;

namespace Lab6
{
    public interface IObservable
    {
        public event Func<string> CollectReport;

    }
}
