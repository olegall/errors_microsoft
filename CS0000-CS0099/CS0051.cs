using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0051
    {
        // CS0051.cs
        public class A
        {
            // Try making B public since F is public
            // B is implicitly private here.
            class B
            {
            }

            public static void F(B b)  // CS0051
            {
            }

            public static void Main()
            {
            }
        }
    }
}
