using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1648
    {
        // CS1648.cs
        public struct Inner
        {
            public int i;
        }

        class Outer
        {
            public readonly Inner inner = new Inner();
        }

        class D
        {
            static void Main()
            {
                var outer = new Outer();
                outer.inner.i = 1;  // CS1648
            }
        }
    }
}
