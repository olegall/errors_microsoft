using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0056
    {
        // CS0056.cs  
        class MyClass
        // try the following line instead  
        // public class MyClass  
        {
        }

        public class A
        {
            public static implicit operator MyClass(A a)   // CS0056  
            {
                return new MyClass();
            }

            public static void Main()
            {
            }
        }
    }
}
