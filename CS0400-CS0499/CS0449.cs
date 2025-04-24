
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0449
    {
        // CS0449.cs  
        // compile with: /target:library  
        interface I { }
        public class C4
        {
            public void F1<T>() where T : class, struct, I { }   // CS0449  
            public void F2<T>() where T : I, struct { }   // CS0449  
            public void F3<T>() where T : I, class { }   // CS0449  

            // OK  
            public void F4<T>() where T : class { }
            public void F5<T>() where T : struct { }
            public void F6<T>() where T : I { }
        }
    }
}
