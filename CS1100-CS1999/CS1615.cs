
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1615
    {
        // CS1615.cs  
        class C
        {
            public void f(int i) { }
            public static void Main()
            {
                int i = 1;
                f(ref i);  // CS1615  
            }
        }
    }
}
