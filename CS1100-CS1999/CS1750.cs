
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1750
    {
        public struct S
        {
            public override string ToString() { return "S::ToString"; } // TODO смысл override - что метод того же класса
        }

        public class A
        {
            public static S Goo(S p = 42) { return p; }
            public static S Goo2(S p = new S()) { return p; }
        }
    }
}