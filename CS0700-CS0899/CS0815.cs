using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0815
    {
        // cs0815.cs  
        class Test
        {
            public static int Main()
            {
                var d = s => -1; // CS0815  
                var e = (string s) => 0; // CS0815 for C# versions before 10
                var p = null; // CS0815  
                var del = delegate (string a) { return -1; }; // CS0815  
                return -1;
            }
        }
    }
}
