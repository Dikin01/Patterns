using System;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool success;
            BoardAnyCar car;

            Console.WriteLine("Lab1");
            car = new BoardBus();
            success = car.isMoving();
            Console.WriteLine("Может ли теперь ехать автобус = " + success);

            car = new BoardTaxi();
            success = car.isMoving();
            Console.WriteLine("Может ли теперь ехать такси = " + success);

            car = new BoardPizza();
            success = car.isMoving();
            Console.WriteLine("Может ли теперь ехать пицца = " + success);

        }
    }
}
