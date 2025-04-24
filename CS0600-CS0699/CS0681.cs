
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0681
    {
        // CS0681.cs  
        // compile with: /target:library  
        abstract class C
        {
            abstract int num;  // CS0681  
        }
    }
}
