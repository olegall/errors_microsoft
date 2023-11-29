using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0110
    {
        public class A
        {
            public static void Main()
            {
            }
        }

        public class B : A
        {
            public const int i = c + 1;   // CS0110, c already references i  
            public const int c = i + 1;
            // the following line would be OK  
            // public const int c = 10;  
        }
    }
}
