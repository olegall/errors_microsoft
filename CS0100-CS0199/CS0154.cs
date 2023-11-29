using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0154
    {
        // CS0154.cs  
        public class MyClass2
        {
            public int i
            {
                set
                {
                }
                // uncomment the get method to resolve this error  
                /*  
                get  
                {  
                    return 0;  
                }  
                */
            }
        }

        public class MyClass
        {
            public static void Main()
            {
                MyClass2 myClass2 = new MyClass2();
                int j = myClass2.i;   // CS0154, no get method  
            }
        }
    }
}
