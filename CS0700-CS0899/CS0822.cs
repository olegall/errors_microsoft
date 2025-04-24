
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0822
    {
        // cs0822.cs  
        class A
        {

            public static int Main()
            {
                const var x = 0; // CS0822.cs  
                const int x2 = 0;
                return -1;
            }
        }
    }
}
