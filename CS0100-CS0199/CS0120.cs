
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    public class MyClass
    {
        // Non-static field.
        public int i;

        // Non-static method.
        public void f() { }

        // Non-static property.
        int Prop
        {
            get
            {
                return 1;
            }
        }

        public static void Main()
        {
            i = 10;   // CS0120
            new MyClass().i = 10;

            f();   // CS0120

            int p = Prop;   // CS0120
        }
    }
}
