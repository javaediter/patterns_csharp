namespace Patterns.Singleton.Model
{
    public class SalesWindowSingleton
    {
        private static int Counter;
        private static SalesWindowSingleton? Instance;
        private SalesWindowSingleton() 
        {
            ++Counter;
        }
        public static SalesWindowSingleton GetInstance()
        {
            Instance ??= new SalesWindowSingleton();
            return Instance;
        }
        public static int GetCounter() {  return Counter; }

        public void Display()
        {
            Console.WriteLine("I'm a singleton instance {0} times", Counter);
        }
    }
}
