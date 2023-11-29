using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0466
    {
        // CS0466.cs  
        interface I
        {
            void F1(params int[] a);
            void F2(int[] a);
        }

        class C : I
        {
            void I.F1(params int[] a) { }
            void I.F2(params int[] a) { }   // CS0466  
            void I.F2(int[] a) { }   // OK  

            public static void Main()
            {
                I i = (I)new C();

                i.F1(new int[] { 1, 2 });
                i.F2(new int[] { 1, 2 });
            }
        }
    }
}
