using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0506
    {
        abstract public class ClassX
        {
            public int i = 0;

            public int f()
            {
                return 0;
            }
            // Try the following definition for f() instead:  
            // abstract public int f();  
        }

        public class ClassY : ClassX
        {
            public override int f()   // CS0506  
            {
                return 0;
            }

            public static int Main()
            {
                return 0;
            }
        }
    }
}
