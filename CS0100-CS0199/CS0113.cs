
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0113
    {
        abstract public class MyClass
        {
            public abstract void Foo();
        }

        public class MyClass2 : MyClass
        {
            override new public void Foo()   // CS0113, remove new keyword  
            {
            }

            public static int Main()
            {
                return 0;
            }
        }
    }
}
