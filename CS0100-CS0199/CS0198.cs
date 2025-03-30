using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0198
    {
        // CS0198.cs  
        class MyClass
        {
            public static readonly int TestInt = 6;
            //public static int TestInt = 6;

            MyClass()
            {
                TestInt = 11;   // CS0198, constructor is not static and readonly field is  
            }
            
            static MyClass()
            {
                TestInt = 11;
            }

            public static void Main()
            {
            }
        }
    }
}
