using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Milk : CondimentDecorator
    {
        Beverage beverege;
        public Milk(Beverage beverage)
        {
            this.beverege = beverage;
        }

        public override decimal cost()
        {
            return 30 + beverege.cost();
        }

        public override string getDescription()
        {
            return beverege.getDescription() + ", Milk";
        }
    }
}
