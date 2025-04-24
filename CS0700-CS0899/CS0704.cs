
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0704
    {
        // CS0704.cs  
        class B
        {
            public class I { }
        }

        class C<T> where T : B
        {
            T.I f;  // CS0704 – member lookup on type parameter  
            // Try this instead:  
            // B.I f;  
        }

        class CMain
        {
            public static void Main() { }
        }
    }
}
