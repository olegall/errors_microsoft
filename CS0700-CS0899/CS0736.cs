using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0736
    {
        interface ITest
        {
            int testMethod(int x);
        }

        class Program : ITest // CS0736  
        {
            public static int testMethod(int x) { return 0; }
            // Try the following line instead.  
            // public int testMethod(int x) { return 0; }  
            public static void Main() { }
        }
    }
}
