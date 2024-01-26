using Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Model
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< silence >>");
        }
    }
}
