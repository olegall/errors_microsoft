using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1643
    {
        // CS1643.cs  
        delegate int MyDelegate();

        class C
        {
            static void Main()
            {
                MyDelegate d = delegate
                {                 // CS1643  
                    int i = 0;
                    if (i == 0)
                        return 1;
                };
            }
        }
    }
}
