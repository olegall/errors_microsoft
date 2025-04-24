
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0737
    {
        // cs0737.cs  
        interface ITest
        {
            // Default access of private with no modifier.  
            int Return42();
            // Try the following line instead.  
            // public int Return42();  
        }

        struct Struct1 : ITest // CS0737  
        {
            int Return42() { return (42); }
        }

        public class Test
        {
            public static int Main(string[] args)
            {
                Struct1 s1 = new Struct1();

                return (1);
            }

        }
    }
}
