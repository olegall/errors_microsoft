
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1100
    {
        // cs1100.cs  
        static class Test
        {
            static void ExtMethod(int i, this Test c) // CS1100  
            {
            }
        }
    }
}
