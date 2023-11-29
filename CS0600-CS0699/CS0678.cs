using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0678
    {
        class TestClass
        {
            private readonly volatile int i;   // CS0678  
            // try the following line instead  
            // private volatile int i;  

            public static void Main()
            {
            }
        }
    }
}
