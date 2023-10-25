using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class MethodOverLoadding
    {

        public void Foo(int x = 0)
        {
            Console.WriteLine("Foo(int x)");
        }

        public void Foo()
        {
            Console.WriteLine("Foo()");
        }
    }
}
