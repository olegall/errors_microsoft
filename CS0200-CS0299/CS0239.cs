
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0239
    {
        // CS0239.cs  
        abstract class MyClass
        {
            public abstract void f();
        }

        class MyClass2 : MyClass
        {
            public static void Main()
            {
            }

            public override sealed void f()
            {
            }
        }

        class MyClass3 : MyClass2
        {
            public override void f()   // CS0239  
            // Try the following definition instead:  
            // public new void f()  
            {
            }
        }
    }
}
