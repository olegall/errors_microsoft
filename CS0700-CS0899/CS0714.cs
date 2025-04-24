
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0714
    {
        // CS0714.cs  
        interface I
        {
        }

        public static class C : I  // CS0714  
        {
            public static void Main()
            {
            }
        }
    }
}
