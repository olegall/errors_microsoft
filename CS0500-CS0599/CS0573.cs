using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0573
    {
        public class clx
        {
            public static void Main()
            {
            }
        }

        public struct cly
        {
            clx a = new clx();   // CS0573  
                                 // clx a;            // OK  
            int i = 7;           // CS0573  
                                 // int i;            // OK  
        }
    }
}
