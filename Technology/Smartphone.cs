using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Smartphone : Computer
    {
        private bool hasCompass;

        public Smartphone(string argOS, string argProcessor, float argRetailCost, string argModelName) : base(argOS, argProcessor, argRetailCost, argModelName)
        {
            this.OS = argOS;
            this.Processor = argProcessor;
            this.RetailCost = argRetailCost;
            this.ModelName = argModelName;
        }

        public void PrintCompassSpec()
        {
            if (hasCompass)
            {
                Console.WriteLine("This smartphone has a compass");
            }
            else
            {
                Console.WriteLine("Good luck getting around");
            }
        }
    }

}
}
