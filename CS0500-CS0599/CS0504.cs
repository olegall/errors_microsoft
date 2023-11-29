using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0504
    {
        abstract public class clx
        {
            static const int i = 0;   // CS0504, cannot be both static and const  
            abstract public void f();
        }
    }
}
