using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        private int hddTempCelsius;

        public Laptop(string argOS, string argProcessor, float argRetailCost, string argModelName) : base(argOS, argProcessor, argRetailCost, argModelName)
        {
            this.OS = argOS;
            this.Processor = argProcessor;
            this.RetailCost = argRetailCost;
            this.ModelName = argModelName;
        }

        public bool isHddOverheated()
        {
            if (hddTempCelsius > 50)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
