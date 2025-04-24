
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0564
    {
        class C
        {
            public static int operator <<(C c1, C c2) // CS0564  
            // To correct, change second operand to int, like so:  
            // public static int operator << (C c1, int c2)  
            {
                return 0;
            }
            static void Main()
            {
            }
        }
    }
}
