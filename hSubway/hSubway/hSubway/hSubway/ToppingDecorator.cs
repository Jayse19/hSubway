using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public abstract class ToppingDecorator : IBuildSandwich
    {
        private IBuildSandwich _bs;
        public virtual string GetDescription()
        {
            return this._bs.GetDescription();
        }
        public virtual double GetPrice()
        {
            return this._bs.GetPrice();
        }
        public ToppingDecorator(IBuildSandwich aSand)
        {
            this._bs = aSand;
        }
    }
}
