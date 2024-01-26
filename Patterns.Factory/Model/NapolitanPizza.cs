using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory.Model
{
    public class NapolitanPizza : Pizza
    {
        public override void GetTypePizza()
        {
            Console.WriteLine(GetType());
        }
    }
}
