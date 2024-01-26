using Patterns.Decorator.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) 
        { 
            this.beverage = beverage;
            Description = "Soy CondimentDecorator";
        }
        public override double Cost()
        {
            return 0.25 + beverage.Cost();
        }
    }
}
