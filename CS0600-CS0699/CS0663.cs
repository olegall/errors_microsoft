
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0663
    {
        // CS0663.cs  
        class TestClass
        {
            public static void Main()
            {
            }

            public void Test(ref int i)
            {
            }

            public void Test(out int i)   // CS0663  
            {
            }
        }
    }
}
