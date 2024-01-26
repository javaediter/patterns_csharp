using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Model
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
