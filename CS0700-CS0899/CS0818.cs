using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0818
    {
        // cs0818.cs  
        class A
        {
            public static int Main()
            {
                var a; // CS0818  
                return -1;
            }
        }
    }
}
