using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    namespace N2
    {
        public static class B
        {
            public static void X() { }
        }
    }

    namespace N1
    {
        public class C
        {
            void B() { }
            void M() => B.X();   // CS0119
            //void M() => N2.B.X();
        }
    }
}
