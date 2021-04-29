using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Bacon : ToppingDecorator
    {
        public Bacon(BuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Bacon";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.75;
        }
    }
}
