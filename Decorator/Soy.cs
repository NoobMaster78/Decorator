using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Soy : CondimentDecorator
    {
        Beverage beverege;
        public Soy(Beverage beverage)
        {
            this.beverege = beverage;
        }

        public override decimal cost()
        {
            return 35 + beverege.cost();
        }

        public override string getDescription()
        {
            return beverege.getDescription() + ", Soy";
        }
    }
}
