
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0559
    {
        // CS0559.cs  
        // compile with: /target:library  
        public class iii
        {
            public static implicit operator int(iii x)
            {
                return 0;
            }

            public static implicit operator iii(int x)
            {
                return null;
            }

            public static int operator ++(int aa)   // CS0559  
            // try the following line instead  
            // public static iii operator ++(iii aa)  
            {
                return (iii)0;
            }
        }
    }
}
