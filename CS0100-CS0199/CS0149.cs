using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0149
    {
        delegate string MyDelegate(int i);

        class MyClass
        {
            // class member-field of the declared delegate type  
            static MyDelegate dt;

            public static void Main()
            {
                dt = new MyDelegate(17.45);   // CS0149  
                // try the following line instead  
                dt = new MyDelegate(Func2);  
                F(dt);
            }

            public static string Func2(int j)
            {
                Console.WriteLine(j);
                return j.ToString();
            }

            public static void F(MyDelegate myFunc)
            {
                myFunc(8);
            }
        }
    }
}
