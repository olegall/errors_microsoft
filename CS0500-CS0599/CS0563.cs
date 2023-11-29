using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0563
    {
        public static implicit operator int(iii x)
        {
            return 0;
        }
        public static implicit operator iii(int x)
        {
            return null;
        }
        public static int operator +(int aa, int bb)   // CS0563
                                                       // Use the following line instead:  
                                                       // public static int operator +(int aa, iii bb)
        {
            return 0;
        }
        public static void Main()
        {
        }
    }
}
