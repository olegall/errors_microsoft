using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0027
    {
        class MyClass
        {

            int err1 = this.Fun() + 1;  // CS0027

            public int Fun()
            {
                return 10;
            }

            public void Test()
            {
                // valid use of this  
                int err = this.Fun() + 1;
                Console.WriteLine(err);
            }

            public static void Main()
            {
                MyClass c = new MyClass();
                c.Test();
            }
        }
    }
}
