using Patterns.Decorator.Model.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Condiments
{
    public class Whipe : CondimentDecorator
    {
        public Whipe(Beverage beverage) 
        {
            this.beverage = beverage;
            Description = "Whipe CondimentDecorator";
        }
        public override double Cost()
        {
            return 0.35 + beverage.Cost();
        }
    }
}
