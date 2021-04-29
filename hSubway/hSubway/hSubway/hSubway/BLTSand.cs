﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class BLTSand : IBuildSandwich
    {
        Bread bType { get; set; }

        public BLTSand(BreadType bt)
        {
            bType = new Bread(bt);
        }

        public double GetPrice()
        {
            return 2.00 + bType.BreadCost;
        }

        public string GetDescription()
        {
            return "BLT sandwich on " + bType.BreadName;
        }
    }
}
