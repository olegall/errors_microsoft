using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1008
    {
        // CS1008.cs  
        abstract public class clx
        {
            enum splitch : char   // CS1008, char not valid type for enums  
            {
                x, y, z
            }

            public static void Main()
            {
            }
        }
    }
}
