using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0134
    {
        // CS0134.cs
        // compile with: /target:library
        class MyTest { }

        class MyClass
        {
            const MyTest test = new MyTest();   // CS0134

            //OK
            const MyTest test2 = null;
            const System.String test3 = "test";
        }
    }
}
