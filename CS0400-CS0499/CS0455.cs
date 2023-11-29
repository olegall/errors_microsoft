using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0455
    {
        // CS0455.cs  


        public class GenericsErrors
        {
            public class B { }
            public class B2 { }
            public class G6<T> where T : B { public class N<U> where U : B2, T { } } // CS0455  
        }
    }
}
