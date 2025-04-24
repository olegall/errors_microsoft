
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0547
    {
        public class a
        {
            public void i   // CS0547  
                            // Try the following declaration instead:  
                            // public int i  
            {
                get
                {
                    return 0;
                }
            }
        }

        public class b : a
        {
            public static void Main()
            {
            }
        }
    }
}
