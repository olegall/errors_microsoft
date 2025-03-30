using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0058
    {
        // CS0058.cs  
        class MyClass
        // try the following line instead  
        // public class MyClass  
        {
        }

        public delegate MyClass MyClassDel();   // CS0058  
        //public delegate MyClass MyClass();

        public class A
        {
            public static void Main()
            {
            }
        }
    }
}
