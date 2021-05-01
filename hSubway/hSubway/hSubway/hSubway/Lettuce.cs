using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Lettuce : Bread
    {
        public Bread bread;
        public Lettuce(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Lettuce";
        }

        public override double GetPrice()
        {
            return 0.25 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

    }
}
