using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";

        }

        public override decimal cost()
        {
            return 120;
        }
    }
}
