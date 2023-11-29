using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0135
    {
        // CS0135.cs  
        public class MyClass2
        {
            public static int i = 0;

            public static void Main()
            {
                {
                    int i = 4;
                    i++;
                }
                i = 0;   // CS0135  
            }
        }
    }
}
