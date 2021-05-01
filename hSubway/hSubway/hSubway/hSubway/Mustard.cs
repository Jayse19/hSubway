using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class Mustard : Bread
    {
        public Bread bread;
        public Mustard(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Mustard";
        }

        public override double GetPrice()
        {
            return bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
}
