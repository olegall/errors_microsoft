using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1104
    {
        // cs1104.cs  
        // Compile with: /target:library  
        public static class Extensions
        {
            public static void Test<T>(this params T[] tArr) { } // CS1104  
        }
    }
}
