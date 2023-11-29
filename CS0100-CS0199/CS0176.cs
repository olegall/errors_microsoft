using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0176
    {
        // CS0176.cs  
        public class MyClass2
        {
            public static int num;
        }

        public class Test
        {
            public static void Main()
            {
                MyClass2 mc2 = new MyClass2();
                int i = mc2.num;   // CS0176  
                                   // try the following line instead  
                                   // int i = MyClass2.num;  
            }
        }
    }
}
