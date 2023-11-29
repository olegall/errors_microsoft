using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    namespace CS0061
    {
        // CS0061.cs  
        // compile with: /target:library  
        internal interface A { }
        public interface AA : A { }  // CS0061  

        // OK  
        public interface B { }
        internal interface BB : B { }

        internal interface C { }
        internal interface CC : C { }
    }
}
