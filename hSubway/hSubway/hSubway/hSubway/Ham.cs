using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Ham
    {
        public Ham(IBuildSandwich sandwich) : base(sandwich)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription();
        }

        public double GetPrice()
        {
            return base.GetPrice();
        }
    }
}
