
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0840
    {
        class Test
        {
            public int myProp { get; } // CS0840  

            // to create a read-only property  
            // try the following line instead  
            public int myProp2 { get; private set; }

        }
    }
}
