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

            BoardBuilder builder = new BusBuilder();
            BoardDirector boardDirector = new BoardDirector(builder);
            BoardAnyCar board = boardDirector.CreateBoard();
            success = board.isMoving();
            Console.WriteLine("Может ли теперь ехать автобус = " + success);

            builder = new TaxiBuilder();
            boardDirector.Builder = builder;
            board = boardDirector.CreateBoard();
            success = board.isMoving();
            Console.WriteLine("Может ли теперь ехать такси = " + success);

            builder = new BoatBuilder();
            boardDirector.Builder = builder;
            board = boardDirector.CreateBoard();
            success = board.isMoving();
            Console.WriteLine("Может ли теперь ехать лодка = " + success);
        }
    }
}
