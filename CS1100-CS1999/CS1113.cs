using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1113
    {
        public static class Extensions
        {
            public static S ExtMethod(this S s)
            {
                return s;
            }
        }

        public struct S
        {
        }

        public class Test
        {
            static int Main()
            {
                Func<S> f = new S().ExtMethod; // CS1113  
                return 1;
            }
        }
    }
}
