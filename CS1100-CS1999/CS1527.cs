using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    // CS1527.cs  
    namespace Sample
    {
        private class C1 { }             // CS1527  
        protected class C2 { }           // CS1527  
        protected internal class C3 { }  // CS1527  
        private protected class C4 { }   // CS1527
    }

    //cs1527_2.cs  
  
    protected class C4 { }
    private struct S1 { }
}
