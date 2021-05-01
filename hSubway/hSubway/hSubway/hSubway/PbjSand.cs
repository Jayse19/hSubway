using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class PbjSand : Bread
    {
        public PbjSand()
        {
            this.Name = "Peanut Butter and Jelly Sandwich";
        }

        public override double GetPrice()
        {
            return 0.75;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
}
