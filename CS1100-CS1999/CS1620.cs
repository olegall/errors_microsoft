using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1620 
    {
        // CS1620.cs  
        class C
        {
            void f(ref int i) { }
            public static void Main()
            {
                int x = 1;
                f(out x);  // CS1620 – f takes a ref parameter, not an out parameter  
                           // Try this line instead:  
                           // f(ref x);  
            }
        }
    }
}
