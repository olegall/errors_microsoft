
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0556
    {
        public class ii
        {
            public class iii
            {
                public static implicit operator int(byte aa)   // CS0556  
                                                               // try the following line instead  
                                                               // public static implicit operator int(iii aa)  
                {
                    return 0;
                }
            }

            public static void Main()
            {
            }
        }
    }
}
