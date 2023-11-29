using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0590
    {
        public class a
        {
            public static void operator +(a A1, a A2)   // CS0590  
            {
            }

            // try the following user-defined operator  
            /*  
            public static a operator+(a A1, a A2)  
            {  
               return A2;  
            }  
            */

            public static int Main()
            {
                return 1;
            }
        }
    }
}
