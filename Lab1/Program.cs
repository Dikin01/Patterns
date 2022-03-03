using System;
using System.Collections.Generic;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool success;
            BoardPizza bus = new BoardPizza();



            Console.WriteLine("Lab1");
            success = bus.isMoving();
            Console.WriteLine("Может ли теперь ехать автобус = " + success);
            
            




        }
    }
}
