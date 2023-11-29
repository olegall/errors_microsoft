using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0669
    {
        [ComImport, Guid("00000000-0000-0000-0000-000000000001")]
        class TestClass
        {
            TestClass()   // CS0669, delete constructor to resolve
            {
            }

            public static void Main()
            {
            }
        }
    }
}
