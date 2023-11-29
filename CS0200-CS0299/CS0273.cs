using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0273
    {
        // CS0273.cs
        // compile with: /target:library
        public class MyClass
        {
            internal int Property
            {
                get { return 0; }
                internal set { }   // CS0273
                // try the following line instead
                // private set {}
            }
        }
    }
}
