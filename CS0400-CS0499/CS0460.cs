
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0460
    {
        // CS0460.cs  
        // compile with: /target:library  
        class BaseClass
        {
            BaseClass() { }
        }

        interface I
        {
            void F1<T>() where T : BaseClass;
            void F2<T>() where T : struct;
            void F3<T>() where T : BaseClass;
        }

        class ExpImpl : I
        {
            void I.F1<T>() where T : BaseClass { }   // CS0460  
            void I.F2<T>() where T : class { }  // CS0460  
        }
    }
}
