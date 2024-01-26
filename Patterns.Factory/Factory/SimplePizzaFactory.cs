using Patterns.Factory.Enum;
using Patterns.Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Factory
{
    public class SimplePizzaFactory
    {
        public static Pizza CreatePizza(TypePizza typePizza)
        {
            if (typePizza.Equals(TypePizza.CHEESE))
            {
                return new CheesePizza();
            }else if (typePizza.Equals(TypePizza.PEPPERONI))
            {
                return new PepporoniPizza();
            }else if (typePizza.Equals(TypePizza.VEGGIE))
            {
                return new VeggiePizza();
            }else if (typePizza.Equals(TypePizza.CLAM))
            {
                return new ClamPizza();
            }else
            {
                return new NapolitanPizza();
            }
        }
    }
}
