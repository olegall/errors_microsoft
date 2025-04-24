
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0544
    {
        public class a
        {
            public int i;
        }

        public class b : a
        {
            public override int i
            {   // CS0544  
            // try the following line instead  
            // public new int i {  
                get
                {
                    return 0;
                }
            }
        }
    }
}
