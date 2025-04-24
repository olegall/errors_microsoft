
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1020
    {
        // CS1020.cs  
        public class iii
        {
            public static int operator ++(iii aa, int bb)   // CS1020, change ++ to +  
            {
                return 0;
            }

            public static void Main()
            {
            }
        }
    }
}