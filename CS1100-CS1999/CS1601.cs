
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1601
    {
        class MyClass
        {
            public void Test1(in TypedReference t)   // CS1601  
            {
            }

            public void Test2(ref TypedReference t)   // CS1601  
            {
            }

            public void Test3(out ArgIterator t)   // CS1601  
            {
                t = default;
            }
        }
    }
}
