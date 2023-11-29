using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0622
    {
        public class Test
        {
            public static void Main()
            {
                Test t = { new Test() };   // CS0622  
                // Try the following instead:  
                // Test[] t = { new Test() };  
            }
        }
    }
}
