
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CS1678
{
    // CS1678  
    delegate void D(int i);
    class Errors
    {
        static void Main()
        {
            D d = delegate (string s) { };   // CS1678  
            // To resolve, use the following line instead:  
            // D d = delegate(int s) { };  
        }
    }
}