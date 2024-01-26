using Patterns.Decorator.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
    }
}
