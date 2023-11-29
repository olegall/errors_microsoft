using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0662
    {
        interface I
        {
            void method([Out] ref int i);   // CS0662  
                                            // try one of the following lines instead  
            // void method(ref int i);  
            // void method([Out, In]ref int i);  
        }

        class test
        {
            public static void Main()
            {
            }
        }
    }
}
