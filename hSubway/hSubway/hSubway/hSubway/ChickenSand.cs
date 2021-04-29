using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class ChickenSand : BuildSandwich
    {
        Bread breadType { get; set; }

        public ChickenSand(BreadType bt)
        {
            breadType = new Bread(bt);
        }

        public double GetPrice()
        {
            return 2.00 + breadType.BreadCost;
        }

        public string GetDescription()
        {
            return "Shredded Chicken Sandwich on " + breadType.BreadName;
        }
    }
}
