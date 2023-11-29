using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0413
    {
        // CS0413.cs  
        // compile with: /target:library  
        class A { }
        class B : A { }

        class CMain
        {
            A a = null;
            public void G<T>()
            {
                a = new A();
                System.Console.WriteLine(a as T);  // CS0413  
            }

            // OK  
            public void H<T>() where T : A
            {
                a = new A();
                System.Console.WriteLine(a as T);
            }
        }
    }
}
