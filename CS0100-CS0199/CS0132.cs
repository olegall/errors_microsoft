using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0132
    {
        public class MyClass
        {
            public MyClass(int i) {}
            //public MyClass() {}
        }

        public class MyClass2 : MyClass
        {
            //static MyClass2(int i) { }   // CS0132  
            MyClass2(int i) : base(1) { }
        }
    }
}
