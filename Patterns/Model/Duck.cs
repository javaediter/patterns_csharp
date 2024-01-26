using Patterns.Interfaces;

namespace Patterns.Model
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void PerformanceFly()
        {
            flyBehavior.Fly();
        }

        public void PerformanceQuack()
        {
            quackBehavior.Quack();
        }

        public override string ToString()
        {
            return string.Format("{0} => {1} and {2}", this.GetType().Name, flyBehavior.GetType().Name, quackBehavior.GetType().Name);
        }
        
        public abstract void Display();
    }
}
