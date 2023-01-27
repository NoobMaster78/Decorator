using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class HouseBlend : Beverage

    {
        public HouseBlend()
        {
            description = "HouseBlend";

        }

        public override decimal cost()
        {
            return 90;
        }
    }
}
