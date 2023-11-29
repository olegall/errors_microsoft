using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0508
    {
        // CS0508.cs  
        // compile with: /target:library  
        abstract public class Clx
        {
            public int i = 0;
            // Return type is int.  
            abstract public int F();
        }

        public class Cly : Clx
        {
            public override double F()
            {
                return 0.0;   // CS0508  
            }
        }
    }
}
