
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0708
    {
        // CS0708.cs  
        // compile with: /target:library  
        public static class C
        {
            int i;  // CS0708  
            static int j;  // OK  
        }
    }
}
