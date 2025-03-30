using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0311
    {
        // cs0311.cs  
        class B { }
        //class B : C { }
        class C { }
        class Test<T> where T : C
        { }

        class Program
        {
            static void Main()
            {
                Test<B> test = new Test<B>(); //CS0311  
                Test<C> test2 = new Test<C>();
            }
        }
    }
}
