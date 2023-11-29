using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0683
    {
        // CS0683.cs  
        interface IExample
        {
            int Test { get; }
        }

        class CExample : IExample
        {
            int IExample.get_Test() { return 0; } // CS0683  
            int IExample.Test { get { return 0; } } // correct  
        }
    }
}
