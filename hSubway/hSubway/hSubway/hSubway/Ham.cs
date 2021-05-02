using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Ham : Bread
    {
        public Bread bread;
        public Ham(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with ham";
        }

        public override double GetPrice()
        {
            return 0.60 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
}
