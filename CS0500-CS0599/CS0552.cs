using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0552
    {
        // CS0552.cs  
        public interface ii
        {
        }

        public class a
        {
            // delete the routine to resolve CS0552  
            public static implicit operator ii(a aa) // CS0552  
            {
                return new ii();
            }

            public static void Main()
            {
            }
        }
    }
}
