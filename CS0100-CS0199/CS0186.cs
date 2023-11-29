using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0186
    {
        class MyClass
        {
            static void Main()
            {
                // Each of the following lines generates CS0186:  
                foreach (int i in null) { }   // CS0186  
                foreach (int i in (IEnumerable)null) { };   // CS0186  
            }
        }
    }
}
