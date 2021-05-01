using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class BBQSauce : Bread
    {
        public Bread bread;
        public BBQSauce(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with BBQ sauce";
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
