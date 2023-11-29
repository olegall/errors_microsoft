using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0054.cs  
    class MyClass
    // try the following line instead  
    // public class MyClass  
    {
    }

    public class MyClass3
    {
        public MyClass this[int i]   // CS0054  
        {
            get
            {
                return new MyClass();
            }
        }
    }

    public class MyClass2
    {
        public static void Main()
        {
        }
    }
}
