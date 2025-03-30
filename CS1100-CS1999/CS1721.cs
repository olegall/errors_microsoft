using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1721
    {
        // CS1721.cs
        public class A { }
        public class B { }
        public class MyClass : A, B { }   // CS1721
    }
}