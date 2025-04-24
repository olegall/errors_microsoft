
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1624 
    {
        class C
        {
            public int Iterator
            // Try this instead:  
            // public IEnumerable Iterator  
            {
                get  // CS1624  
                {
                    yield return 1;
                }
            }
        }
    }
}
