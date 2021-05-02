using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class Mayo : Bread
    {
        public Bread bread;
        public Mayo(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with mayo";
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
