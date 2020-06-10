using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Smartphone : AbstractEntity
    {
        private bool hasCompass;

        public Smartphone(bool argHasCompas, string argOS, string argProcessor, float argRetailCost, string argModelName) : base(argOS, argProcessor, argRetailCost, argModelName)
        {
            hasCompass = argHasCompas;   
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
