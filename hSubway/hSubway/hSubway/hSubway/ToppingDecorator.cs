using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public abstract class ToppingDecorator
    {
        private IBuildSandwich bs;
        public virtual string GetDescription()
        {
            return this.bs.GetDescription();
        }
        public virtual double GetPrice()
        {
            return this.bs.GetPrice();
        }
        public ToppingDecorator(IBuildSandwich aSand)
        {
            this.bs = aSand;
        }
    }
}
