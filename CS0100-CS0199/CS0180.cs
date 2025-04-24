
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0180
    {
        public class MyClass
        {
            public extern abstract int Foo(int a);   // CS0180  

            public static void Main()
            {
            }
        }
    }
}
