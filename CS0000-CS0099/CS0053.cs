using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0053
    {
        // CS0053.cs  
        class MyClass //defaults to private accessibility  
                      // try the following line instead  
                      // public class MyClass  
        {
        }

        public class MyClass2
        {
            public MyClass myProperty   // CS0053  
            {
                get
                {
                    return new MyClass();
                }
                set
                {
                }
            }
        }

        public class MyClass3
        {
            public static void Main()
            {
            }
        }
    }
}
