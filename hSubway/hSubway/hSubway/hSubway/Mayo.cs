using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class Mayo : Bread
    {
        public override string GetDescription()
        {
            return base.GetDescription() + ", Mayo";
        }
    }
}
