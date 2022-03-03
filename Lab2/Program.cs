using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool success;
            

            Console.WriteLine("Lab1");

            BusBuilder builder = new BusBuilder();
            BoardDirector boardDirector = new BoardDirector(builder);
            BoardAnyCar board = boardDirector.CreateBoard();
            success = board.isMoving();
            Console.WriteLine("Может ли теперь ехать автобус = " + success);

            TaxiBuilder builder1 = new TaxiBuilder();
            boardDirector.Builder = builder1;
            board = boardDirector.CreateBoard();
            success = board.isMoving();
            Console.WriteLine("Может ли теперь ехать такси = " + success);
        }
    }
}
