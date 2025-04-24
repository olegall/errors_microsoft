
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CS1676
{
    // CS1677.cs  
    delegate void D(int i);
    class Errors
    {
        static void Main()
        {
            D d = delegate (out int i) { };   // CS1677  
                                              // To resolve, use the following line instead:  
                                              // D d = delegate(int i) { };  

            D d = delegate (ref int j) { }; // CS1677  
                                            // To resolve, use the following line instead:  
                                            // D d = delegate(int j){};  
        }
    }
}