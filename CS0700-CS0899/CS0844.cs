using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0844
    {
        class Test
        {
            int num;
            public void TestMethod()
            {
                num = 5; // CS0844  
                int num = 6;

            }
            public static int Main()
            {
                return 1;
            }
        }

        class Test2
        {
            int num;
            public void TestMethod()
            {
                this.num = 5; // Error fixed.
                int num = 6;
            }
            public static int Main()
            {
                return 1;
            }
        }

        class Test3
        {
            int num;
            public void TestMethod()
            {
                num = 5; // Error fixed.
                int num2 = 6;
            }
            public static int Main()
            {
                return 1;
            }
        }
    }
}
