
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0534
    {
        abstract public class clx
        {
            public abstract void f();
        }

        public class cly : clx   // CS0534, no override for clx::f  
        {
            // uncomment the following sample override to resolve CS0534  
            // override public void f()  
            // {  
            // }  

            public static int Main()
            {
                return 0;
            }
        }
    }
}
