using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0177
    {
        // CS0177.cs  
        public class MyClass
        {
            public static void Foo(out int i)   // CS0177  
            {
                // uncomment the following line to resolve this error  
                //   i = 0;  
            }

            public static void Main()
            {
                int x = -1;
                Foo(out x);
            }
        }
    }
}
