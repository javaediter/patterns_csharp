using Patterns.Decorator.Model.Beverages;
using Patterns.Decorator.Model.Condiments;
using Patterns.Factory.Enum;
using Patterns.Factory.Logic;
using Patterns.Factory.Model;
using Patterns.Model;
using Patterns.Singleton.Model;
using System.Globalization;

//Pattern STRATEGY
Duck mallard = new MallardDuck();
mallard.PerformanceQuack();
mallard.PerformanceFly();
Console.WriteLine(mallard);

Console.WriteLine();

//Pattern FACTORY
Pizza pizza = new PizzaStore().OrderPizza(TypePizza.PEPPERONI);
pizza.GetTypePizza();

Console.WriteLine();

//Pattern SINGLETON
SalesWindowSingleton sales = SalesWindowSingleton.GetInstance();// se crea una sola instancia
sales = SalesWindowSingleton.GetInstance();
sales.Display();

Console.WriteLine();

//Pattern DECORATOR
DarkRoast darkRoast = new DarkRoast();
Console.WriteLine("Cost 1: {0}", darkRoast.Cost().ToString("C", CultureInfo.CurrentCulture));
Mocha mocha = new Mocha(darkRoast);
Console.WriteLine("Cost 2: {0}", mocha.Cost().ToString("C", CultureInfo.CurrentCulture));
Whipe whipe = new Whipe(mocha);
Console.WriteLine("Cost 3: {0}", whipe.Cost().ToString("C", CultureInfo.CurrentCulture));            