using Patterns.Decorator.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) 
        { 
            this.beverage = beverage;
            Description = "Mocha CondimentDecorator";
        }
        public override double Cost()
        {
            return 0.55 + beverage.Cost();
        }
    }
}
