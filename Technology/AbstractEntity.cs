using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity : Computer
    {
        private static int nextId = 1;
        public readonly string id;
        public AbstractEntity(string argOS, string argProcessor, float argRetailCost, string argModelName) : base(argOS, argProcessor, argRetailCost, argModelName)
        {
            id = $"{argModelName}" + "-" + nextId;
            nextId++;
        }
    }
}
