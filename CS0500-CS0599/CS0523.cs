using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0523
    {
        // CS0523.cs
        // compile with: /target:library
        struct SelfReferentialStruct
        {
            public SelfReferentialStruct other;   // CS0523
        }

        class SelfReferentialClass
        {
            public SelfReferentialClass other;   // OK
        }
    }
}
