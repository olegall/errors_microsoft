using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0123
    {
        // CS0123.cs  
        delegate void D();

        delegate void D2(int i);

        public class C
        {
            public static void f(int i) { }

            public static void Main()
            {
                D d = new D(f);   // CS0123  
                D2 d2 = new D2(f);   // OK  
                d2 += f;
                d2 -= f;
                d2(1);
            }
        }
    }
}
