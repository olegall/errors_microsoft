using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0451
    {
        // CS0451.cs  

        public class C4
        {
            public void F4<T>() where T : struct, new() { }   // CS0451  
        }

        // OK  
        public class C5
        {
            public void F5<T>() where T : struct { }
        }

        public class C6
        {
            public void F6<T>() where T : new() { }
        }
    }
}
