using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";

        }

        public override decimal cost()
        {
            return 150;
        }
    }
}
