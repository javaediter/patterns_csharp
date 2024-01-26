using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Model.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "DarkRoast Beverage";
        }
        public override double Cost()
        {
            return 10.80;
        }
    }
}
