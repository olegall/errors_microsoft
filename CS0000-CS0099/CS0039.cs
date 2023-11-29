using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0039
    {
        class A { }
        class B : A { }
        class C : A { }

        class Example
        {
            static void Main()
            {
                C c;

                // This compiles, because
                // there is an explicit reference conversion from type A to type C.
                A a = new C();
                c = a as C;

                // This generates CS0039, because
                // there is no implicit or explicit reference conversion between B and C types.
                B b = new B();
                c = b as C;  // CS0039
            }
        }
    }
}
