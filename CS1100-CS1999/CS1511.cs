
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1511
    {
        // CS1511.cs  
        // compile with: /target:library  
        public class A
        {
            public int j = 0;
        }

        class C : A
        {
            public void Method()
            {
                base.j = 3;   // base allowed here  
                //this.j = 3; // aleek
            }

            public static int StaticMethod()
            {
                base.j = 3;   // CS1511  
                return 1;
            }
        }
    }
}
