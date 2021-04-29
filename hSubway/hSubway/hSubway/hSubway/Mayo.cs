using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    class Mayo
    {
        public override string GetDescription()
        {
            return base.GetDescription() + ", Mayo";
        }

        public override int GetCount()
        {
            return base.GetCount() + 1;
        }
    }
}
