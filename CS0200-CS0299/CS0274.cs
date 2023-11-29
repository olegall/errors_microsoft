using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0274
    {
        // CS0274.cs  
        public class MyClass
        {
            public int Property   // CS0274  
            {
                public get { return 0; }
                protected set { }
            }
        }
    }
}
