using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0454
    {
        // CS0554  
        public class GenericsErrors
        {
            public class G4<T> where T : T { } // CS0454  
        }

        public class Gen<T, U> where T : U where U : T  // CS0454  
        {
        }
    }
}
