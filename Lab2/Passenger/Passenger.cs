﻿namespace Lab2
{
    public abstract class Passenger
    {
        public string Name { protected set; get; }              

        public Passenger(string name = "Иван")
        {
            Name = name;              
        }
    }
}
