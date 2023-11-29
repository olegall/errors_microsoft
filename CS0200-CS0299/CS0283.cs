using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0283
    {
        // CS0283.cs  
        struct MyTest
        {
        }
        class MyClass
        {
            // To resolve the error but retain the "const-ness",  
            // change const to readonly.  
            const MyTest test = new MyTest();   // CS0283  

            public static int Main()
            {
                return 1;
            }
        }
    }
}
