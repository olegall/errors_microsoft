using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1599
    {
        class MyClass
        {
            public static void Main()
            {
            }

            public TypedReference Test1()   // CS1599  
            {
                return null;
            }

            public ArgIterator Test2()   // CS1599  
            {
                return null;
            }
        }
    }
}
