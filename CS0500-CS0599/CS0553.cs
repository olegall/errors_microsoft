using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0553
    {
        public class ii
        {
        }

        public class a : ii
        {
            // delete the conversion routine to resolve CS0553  
            public static implicit operator ii(a aa) // CS0553  
            {
                return new ii();
            }

            public static void Main()
            {
            }
        }
    }
}
