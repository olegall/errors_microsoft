
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0677
    {
        // CS0677.cs  
        class TestClass
        {
            private volatile long i;   // CS0677  
            private volatile int i2;

            public static void Main()
            {
            }
        }
    }
}
