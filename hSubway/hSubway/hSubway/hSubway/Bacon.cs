using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Bacon : ToppingDecorator 
    {
        public Bacon(IBuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription();
        }

        public override double GetPrice()
        {
            return base.GetPrice();
        }
    }
}
