using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1609
    {
        // CS1609.cs  
        // compile with: /target:library  
        delegate int Del();
        class A
        {
            public event Del MyEvent
            {
                private add { }   // CS1609  
                // try the following line instead  
                // add {}  
                remove { }
            }
        }
    }
}
