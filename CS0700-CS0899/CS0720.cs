using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0720
    {
        public static class Test
        {
            public int this[int index]  // CS0720  
            {
                get { return 1; }
                set { }
            }

            static void Main() { }
        }
    }
}
