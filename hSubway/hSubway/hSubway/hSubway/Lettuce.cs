using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Lettuce : ToppingDecorator
    {
        public Lettuce(BuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Lettuce";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.25;
        }
    }
}
