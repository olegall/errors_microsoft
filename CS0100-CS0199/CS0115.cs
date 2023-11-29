using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0115
    {
        abstract public class MyClass1
        {
            public abstract int f();
        }

        abstract public class MyClass2 //: MyClass1
        {
            //public override int f()   // CS0115
            public int f()   // CS0115
            {
                return 0;
            }

            public static void Main()
            {
            }
        }
    }
}
