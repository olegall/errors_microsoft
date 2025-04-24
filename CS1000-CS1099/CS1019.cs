
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1019
    {
        public class ii
        {
            int i
            {
                get
                {
                    return 0;
                }
            }
        }

        public class a
        {
            public int i;
            // Generates CS1019: "ii" is not a unary operator.  
            public static a operator ii(a aa)

            // Use the following line instead:  
            //public static a operator ++(a aa)  
            {
                aa.i++;
                return aa;
            }

            public static void Main()
            {
            }
        }
    }
}