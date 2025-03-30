using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1101
    {
        // cs1101.cs
        // Compile with: /target:library
        public static class Extensions
        {
            public static void Test(ref this int i) { } // CS1101
        }
    }
}
