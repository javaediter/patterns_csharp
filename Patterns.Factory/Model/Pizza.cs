namespace Patterns.Factory.Model
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("preparing...");
        }

        public void Bake()
        {
            Console.WriteLine("baking...");
        }

        public void Cut()
        {
            Console.WriteLine("cuting...");
        }

        public void Box()
        {
            Console.WriteLine("boxing...");
        }

        public abstract void GetTypePizza();
    }
}
