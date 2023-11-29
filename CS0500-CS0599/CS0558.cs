using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0558
    {
        public class ii
        {
            public class iii
            {
                static implicit operator int(iii aa)   // CS0558, add public  
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
