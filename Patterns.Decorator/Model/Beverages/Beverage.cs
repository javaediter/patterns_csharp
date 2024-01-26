namespace Patterns.Decorator.Model.Beverages
{
    public abstract class Beverage
    {
        protected string Description { get; set; }
        public abstract double Cost();
    }
}
