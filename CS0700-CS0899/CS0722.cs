
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0722
    {
        // CS0722.cs  
        public static class SC
        {
        }

        public class CMain
        {
            public SC F()  // CS0722  
            {
                return null;
            }

            public static void Main()
            {
            }
        }
    }
}
