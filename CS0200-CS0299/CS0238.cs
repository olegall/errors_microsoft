using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0238
    {
        // CS0238.cs  
        abstract class MyClass
        {
            public abstract void f();
        }

        class MyClass2 : MyClass
        {
            public static void Main()
            {
            }

            public sealed void f() // CS0238  
                                   // Try the following definition instead:  
                                   // public override sealed void f()  
            {
            }
        }
    }
}
