using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Whip : CondimentDecorator
    {
        Beverage beverege;
        public Whip(Beverage beverage)
        {
            this.beverege = beverage;
        }

        public override decimal cost()
        {
            return 10 + beverege.cost();
        }

        public override string getDescription()
        {
            return beverege.getDescription() + ", Whip";
        }
    }
}
