using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0450
    {
        // CS0450.cs  
        // compile with: /t:library  
        public class GenericsErrors
        {
            public class B { }
            public class G3<T> where T : struct, B { } // CS0450  
            // To resolve, use the following line instead:  
            // public class G3<T> where T : B { }  
        }
    }
}
