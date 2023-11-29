using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0276
    {
        // CS0276.cs  
        public class MyClass
        {
            public int Property
            {
                protected set { }   // CS0276  
            }
            public int Property2
            {
                internal get { }   // CS0276  
            }
        }
    }
}
