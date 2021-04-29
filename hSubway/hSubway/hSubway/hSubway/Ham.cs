using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Ham
    {
        public Ham(BuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Ham";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.60;
        }
    }
}
