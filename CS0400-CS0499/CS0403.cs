
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0403
    {
        // CS0403.cs  
        // compile with: /target:library  
        class C<T>
        {
            public void f()
            {
                T t = null;  // CS0403  
                T t2 = default(T);   // OK  
            }
        }

        class D<T> where T : class
        {
            public void f()
            {
                T t = null;  // OK  
            }
        }
    }
}
