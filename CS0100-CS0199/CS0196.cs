using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0196
    {
        // CS0196.cs  
        public class MyClass
        {
            public static void Main()
            {
                int* i = null;
                int j = 0;
                j = i[1, 2];   // CS0196  
                               // try the following line instead  
                               // j = i[1];  
            }
        }
    }
}
