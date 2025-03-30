using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1662
    {
        delegate int MyDelegate(int i);

        class C
        {

            public static void Main()
            {
                MyDelegate d = delegate (int i) { return 1.0; };  // CS1662
                // Try this instead:
                // MyDelegate d = delegate(int i) { return (int)1.0; };
            }
        }
    }
}