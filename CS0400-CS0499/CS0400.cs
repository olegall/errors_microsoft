using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0400
    {
        // CS0400.cs  
        class C
        {
            public static void Main()
            {
                // CS0400 - D could not be found
                // in the global namespace.  
                global::D d = new global::D();
            }
        }
    }
}
