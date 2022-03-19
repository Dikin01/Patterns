using System;

namespace Lab6
{
    public interface IObservable

    {
        public event Func<string> CollectReport;

        //Сюда нужно для Фёдорова явно добавить методы Add и Remove с параметром типа IObservable

       /* public void Add(IObservable observable);
        public void Remove(IObservable observable);*/

    }
}
