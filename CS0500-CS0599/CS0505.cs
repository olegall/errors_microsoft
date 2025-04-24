
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0505
    {
        // CS0505.cs  
        // compile with: /target:library  
        public class clx
        {
            public int i;
        }

        public class cly : clx
        {
            public override int i() { return 0; }   // CS0505  
        }
    }
}
