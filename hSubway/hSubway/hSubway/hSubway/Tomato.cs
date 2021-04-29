using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class Tomato:ToppingDecorator 
    {
        public Tomato(BuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Tomato";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.25;
        }
    }
}
