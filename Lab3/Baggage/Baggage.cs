﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Baggage
    {
        public double Weight { get; protected set; }
        public StateBaggage StateBaggage { get; set; }

        public Baggage()
        {
            StateBaggage = StateBaggage.NotRegistered;
            Weight = 10;
        }
    }
}