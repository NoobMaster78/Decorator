using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        Beverage beverege;
        public Mocha(Beverage beverage)
        {
            this.beverege = beverage;
        }

        public override decimal cost()
        {
            return 25 + beverege.cost(); 
        }

        public override string getDescription()
        {
            return beverege.getDescription() + ", Mocha";
        }
    }
}
