using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0575
    {
        public struct iii
        {
            ~iii()   // CS0575  
            {
            }

            public static void Main()
            {
            }
        }
    }
}
