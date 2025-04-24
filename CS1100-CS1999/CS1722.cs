
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1722
    {
        // CS1722.cs  
        // compile with: /target:library  
        public class A { }
        interface I { }

        public class MyClass : I, A { }   // CS1722  
        public class MyClass2 : A, I { }   // OK
    }
}