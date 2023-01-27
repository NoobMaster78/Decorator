using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Beverage
    {
        protected string description;

        public virtual string getDescription()
        {
            return description;
        }

        public abstract decimal cost();
    }
}
