using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class BBQSauce : Bread
    {
        public override string GetDescription()
        {
            return base.GetDescription() + ", BBQ Sauce";
         }
    }
