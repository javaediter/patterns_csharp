using Patterns.Decorator.Model.Beverages;
using Patterns.Decorator.Model.Condiments;
using Patterns.Factory.Enum;
using Patterns.Factory.Logic;
using Patterns.Factory.Model;
using Patterns.Model;
using Patterns.Singleton.Model;

namespace Patterns.Tests.Tests
{
    public class PatternsTest
    {
        [Fact]
        public void Test_Pattern_STRATEGY()
        {
            Duck mallard = new MallardDuck();
            Assert.Equal("MallardDuck => FlyWithWings and Quack", mallard.ToString());
        }

        [Fact]
        public void Test_Pattern_DECORATOR()
        {
            DarkRoast darkRoast = new DarkRoast();
            Mocha mocha = new Mocha(darkRoast);
            Assert.True(mocha.Cost() > 0);
        }

        [Fact]
        public void Test_Pattern_FACTORY()
        {
            Pizza pizza = new PizzaStore().OrderPizza(TypePizza.PEPPERONI);
            Assert.IsType<PepporoniPizza>(pizza);
        }

        [Fact]
        public void Test_Pattern_SINGLETON()
        {
            SalesWindowSingleton sales = SalesWindowSingleton.GetInstance();
            sales = SalesWindowSingleton.GetInstance();
            Assert.Equal(1, SalesWindowSingleton.GetCounter());
        }
    }
}