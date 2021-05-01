using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class ChickenSand : Bread
    {
        public ChickenSand()
        {
            this.Name = "Shredded Chicken Sandwich";
        }

        public override double GetPrice()
        {
            return 2.00;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

    }
}
