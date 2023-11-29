using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0442
    {
        // CS0442.cs  
        public abstract class MyClass
        {
            public abstract int AbstractProperty
            {
                get;
                private set;   // CS0442  
                               // Try this instead:  
                               // set;  
            }
        }
    }
}
