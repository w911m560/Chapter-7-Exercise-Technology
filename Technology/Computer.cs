﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {
        public string OS { get; set; }
        public string Processor { get; set; }
        public double RetailCost { get; set; }
        public readonly string modelName;

        public Computer(string argOS, string argProcessor, float argRetailCost, string argModelName)
        {
            OS = argOS;
            Processor = argProcessor;
            RetailCost = argRetailCost;
            modelName = argModelName;
        }

        public void PrintOS()
        {
            Console.WriteLine("OS: " + OS);
        }

        public void GiveDiscount()
        {
           RetailCost -= RetailCost * .05;
        }
    }
}
