using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0050
    {
        // CS0050.cs
        class MyClass // Accessibility defaults to private.
                      // Try the following line instead.
                      // public class MyClass
        {
        }

        public class MyClass2
        {
            public static MyClass MyMethod()   // CS0050
            {
                return new MyClass();
            }

            public static void Main() { }
        }
    }
}
