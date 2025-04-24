
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0151
    {
        public class MyClass
        {
            public static implicit operator int(MyClass aa)
            {
                return 0;
            }

            public static implicit operator long(MyClass aa)
            {
                return 0;
            }

            public static void Main()
            {
                MyClass a = new MyClass();

                // Compiler cannot choose between int and long.
                switch (a)   // CS0151
                // try the following line instead
                //switch ((int)a)
                {
                    case 1:
                        break;
                }
            }
        }
    }
}
