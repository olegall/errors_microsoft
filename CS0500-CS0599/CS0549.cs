using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0549
    {
        // CS0549.cs  
        // compile with: /target:library  
        sealed public class MyClass
        {
            virtual public void TestMethod() { }   // CS0549  
            public void TestMethod2() { }   // OK  
        }
    }
}
