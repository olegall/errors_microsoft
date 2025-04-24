
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0572
    {
        class C
        {
            public class Inner
            {
                public static int v = 9;
            }
        }

        class D : C
        {
            public static void Main()
            {
                C cValue = new C();
                Console.WriteLine(cValue.Inner.v);   // CS0572  
                                                     // try the following line instead  
                                                     // Console.WriteLine(C.Inner.v);  
            }
        }
    }
}
