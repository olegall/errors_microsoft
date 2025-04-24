
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1065
    {
        // CS1065.cs (5,27)

        class A
        {
            delegate void D(int x);
            D d1 = delegate (int x = 42) { };
            D d2 = delegate (int x) { };
        }
    }
}