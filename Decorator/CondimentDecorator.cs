﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract override string getDescription();
    }
}
