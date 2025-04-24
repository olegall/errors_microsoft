
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0191
    {
        // CS0191.cs

        // CS0191 также возвращает результат, readonly если поле является статическим и конструктор не помечен как static.

        class MyClass
        {
            public readonly int TestInt = 6;  // OK to assign to readonly field in declaration  

            MyClass()
            {
                TestInt = 11; // OK to assign to readonly field in constructor  
            }

            public void TestReadOnly()
            {
                TestInt = 19;                  // CS0191  
            }

            public static void Main()
            {
            }
        }
    }
}
