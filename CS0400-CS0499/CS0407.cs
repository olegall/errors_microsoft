
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0407
    {
        // CS0407.cs  
        public delegate int MyDelegate();

        class C
        {
            MyDelegate d;

            public C()
            {
                d = new MyDelegate(F);  // OK: F returns int  
                d = new MyDelegate(G);  // CS0407 – G doesn't return int  
            }

            public int F()
            {
                return 1;
            }

            public void G()
            {
            }

            public static void Main()
            {
                C c1 = new C();
            }
        }
    }
}
