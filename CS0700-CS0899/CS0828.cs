
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0828
    {
        // cs0828.cs  


        public class C
        {
            public static int Main()
            {
                var a = 1;
                var c = new { p1 = null }; // CS0828  
                return 1;
            }
        }
    }
}
