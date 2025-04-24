
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0470
    {
        interface I
        {
            int P { get; }
        }

        class MyClass : I
        {
            public int get_P() { return 0; }   // CS0470  
            public int P2 { get { return 0; } }   // OK  
            public int P { get { return 0; } }   // OK  
        }
    }
}
