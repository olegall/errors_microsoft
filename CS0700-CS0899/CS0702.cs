using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0702
    {
        // CS0702.cs
        class C<T> where T : System.Array  // CS0702
        {
        }
    }
}
