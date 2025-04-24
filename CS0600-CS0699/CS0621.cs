
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0621
    {
        // CS0621.cs  
        abstract class MyClass
        {
            private virtual void DoNothing1()   // CS0621  
            {
            }

            private abstract void DoNothing2();   // CS0621  

            public static void Main()
            {
            }
        }
    }
}
