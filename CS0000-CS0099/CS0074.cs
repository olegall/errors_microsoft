
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0074
    {
        // CS0074.cs  
        delegate void D();

        abstract class Test
        {
            public abstract event D e = null;   // CS0074  
            // try the following line instead  
            // public abstract event D e;  
            //public event D e2 = null;
            
            public static void Main()
            {
            }
        }
    }
}
