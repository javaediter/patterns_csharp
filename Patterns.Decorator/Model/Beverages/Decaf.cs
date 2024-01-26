using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Beverage";
        }
        public override double Cost()
        {
            return 10.50;
        }
    }
}
