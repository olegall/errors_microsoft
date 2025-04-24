
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1660
    {
        // CS1660.cs  
        delegate int MyDelegate();
        class C
        {
            static void Main()
            {
                int i = delegate { return 1; };  // CS1660  
                // Try this instead:  
                // MyDelegate myDelegate = delegate { return 1; };  
                // int i = myDelegate();  
            }
        }
    }
}