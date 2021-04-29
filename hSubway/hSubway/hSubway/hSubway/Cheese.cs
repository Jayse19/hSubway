using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Cheese: ToppingDecorator
    {
        public Cheese(IBuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Cheese";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.75;
        }
    }
}
