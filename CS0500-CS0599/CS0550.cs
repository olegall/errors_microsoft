using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0550
    {
        interface ii
        {
            int i
            {
                get;
                // add the following accessor to resolve this CS0550  
                // set;  
            }
        }

        public class a : ii
        {
            int ii.i
            {
                get
                {
                    return 0;
                }
                set { }   // CS0550  no set in interface  
            }

            public static void Main() { }
        }
    }
}
