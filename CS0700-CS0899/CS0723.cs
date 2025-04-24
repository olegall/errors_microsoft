
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0723
    {
        // CS0723.cs  
        public static class SC
        {
        }

        public class CMain
        {
            public static void Main()
            {
                SC sc = null;  // CS0723  
            }
        }
    }
}
