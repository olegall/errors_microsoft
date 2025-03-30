using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1593
    {
        delegate string func(int i);   // declare delegate  

        class a
        {
            public static void Main()
            {
                func dt = new func(z);
                x(dt);
            }

            public static string z(int j)
            {
                Console.WriteLine(j);
                return j.ToString();
            }

            public static void x(func hello)
            {
                hello(8, 9);   // CS1593  
                // try the following line instead  
                // hello(8);  
            }
        }
    }
}
