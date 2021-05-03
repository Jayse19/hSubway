using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class Cheese: Bread
    {
        public Bread bread;
        public Cheese(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with cheese";
        }

        public override double GetPrice()
        {
            return 0.75 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
}
