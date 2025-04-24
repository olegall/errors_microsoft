
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0448
    {
        // CS0448.cs  
        class C5
        {
            public static int operator ++(C5 c) { return null; }   // CS0448  
            public static C5 operator --(C5 c) { return null; }   // OK  
            public static void Main() { }
        }
    }
}
