using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0543
    {
        enum I : byte
        { a = 255, b, c }   // CS0543  
        public class clx
        {
            public static int Main()
            {
                return 0;
            }
        }
    }
}
