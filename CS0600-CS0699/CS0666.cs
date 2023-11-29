using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0666
    {
        // CS0666.cs  
        class M
        {
            static void Main()
            {
            }
        }

        struct S
        {
            protected int x;   // CS0666  
        }
    }
}
