using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0157
    {
        public class MyClass2 : Exception
        {
        }

        public class MyClass
        {
            public static void Main()
            {
                try
                {
                }
                finally
                {
                    return;   // CS0157, cannot leave finally clause  
                }
            }
        }
    }
}
