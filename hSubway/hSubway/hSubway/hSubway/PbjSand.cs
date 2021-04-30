using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class PbjSand : IBuildSandwich
    {
        Bread bType;

        public PbjSand(Bread bt)
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
