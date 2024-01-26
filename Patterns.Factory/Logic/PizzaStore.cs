using Patterns.Factory.Enum;
using Patterns.Factory.Factory;
using Patterns.Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Logic
{
    public class PizzaStore
    {
        public Pizza OrderPizza(TypePizza type)
        {
            Pizza pizza;
            pizza = SimplePizzaFactory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
