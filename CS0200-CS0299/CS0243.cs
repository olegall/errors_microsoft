using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0243
    {
        // CS0243.cs  
        // compile with: /target:library  
        public class MyClass
        {
            public virtual void M() { }
        }

        public class MyClass2 : MyClass
        {
            [System.Diagnostics.ConditionalAttribute("MySymbol")]   // CS0243  
                                                                    // remove Conditional attribute or remove override keyword  
            public override void M() { }
        }
    }
}
