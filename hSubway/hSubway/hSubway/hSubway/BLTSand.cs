using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class BLTSand : Bread
    {
        public BLTSand()
        {
            this.Name = "BLT sandwich";
        }

        public override double GetPrice()
        {
            return 2.50;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }
}
