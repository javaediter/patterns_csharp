using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso Beverage";
        }
        public override double Cost()
        {
            return 10.80;
        }
    }
}
