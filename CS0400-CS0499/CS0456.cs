using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0456
    {
        // CS0455.cs  


        // CS0456.cs  
        // compile with: /target:library  
        public class GenericsErrors
        {
            public class G5<T> where T : struct
            {
                public class N<U> where U : T { }   // CS0456  
                public class N2<U> where U : struct { }   // OK  
            }
        }
    }
}
