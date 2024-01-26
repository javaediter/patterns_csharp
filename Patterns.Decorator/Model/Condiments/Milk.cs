using Patterns.Decorator.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) 
        {
            Description = "Milk CondimentDecorator";
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 0.45 + this.beverage.Cost();
        }
    }
}
