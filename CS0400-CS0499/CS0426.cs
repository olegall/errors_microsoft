using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0426
    {
        // CS0426.cs  

        class C
        {
            // No nested types are declared.
        }

        class D
        {
            public static void Main()
            {
                C c = new C();
                // Attempt to reference a nested type A:  
                C.A a; // CS0426 because no such type C.A  
            }
        }
    }
}
