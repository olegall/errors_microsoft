using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0156
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
                    throw;   // CS0156  
                }

                catch (MyClass2)
                {
                    throw;   // this throw is valid  
                }
            }
        }
    }
}
