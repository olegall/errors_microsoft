
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0673
    {
        // CS0673.cs  
        class MyClass
        {
            public static void Main()
            {
                System.Type t = typeof(System.Void);   // CS0673  
                // try the following line instead  
                // System.Type t = typeof(void);  
            }
        }
    }
}
