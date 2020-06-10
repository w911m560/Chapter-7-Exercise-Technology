using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : AbstractEntity
    {
        private int hddTempCelsius;

        public Laptop(int argHddTempCelius, string argOS, string argProcessor, float argRetailCost, string argModelName) : base(argOS, argProcessor, argRetailCost, argModelName)
        {
            hddTempCelsius = argHddTempCelius;
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
