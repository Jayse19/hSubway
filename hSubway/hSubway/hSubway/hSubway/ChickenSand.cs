using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class ChickenSand : IBuildSandwich
    {
        Bread bType;

        public ChickenSand(Bread bt)
        {
            bType = bt;
        }

        public double GetPrice()
        {
            return GetPrice();
        }

        public string GetDescription()
        {
            return GetDescription();
        }
    }
}
