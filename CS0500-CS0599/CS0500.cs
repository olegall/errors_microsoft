using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0500
    {
        abstract public class clx
        {
            abstract public void f() { }   // CS0500  
                                           // try the following line instead  
                                           // abstract public void f();  
        }

        public class cly
        {
            public static int Main()
            {
                return 0;
            }
        }
    }
}
