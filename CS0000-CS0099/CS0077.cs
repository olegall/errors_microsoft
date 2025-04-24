
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0077
    {
        class C
        {
        }

        struct S
        {
        }

        class M
        {
            public static void Main()
            {
                object o1, o2;
                C c;
                S s;

                o1 = new C();
                o2 = new S();

                s = o2 as S;
                // CS0077, S is not a reference type.  
                // Try the following line instead.  
                // c = o1 as C;  

                object o3 = new C(); // всё что кроме object - объекты, поэтому cast не нужен
                C c3 = (C)new object(); // C нужно свой (подходящий, совместимый) объект
            }
        }
    }
}
