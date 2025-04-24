
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0217
    {
        public class MyClass
        {
            public static bool operator true(MyClass f)
            {
                return false;
            }

            public static bool operator false(MyClass f)
            {
                return false;
            }

            public static implicit operator int(MyClass x)
            {
                return 0;
            }

            public static int operator &(MyClass f1, MyClass f2)   // CS0217  
                                                                   // try the following line instead  
                                                                   // public static MyClass operator & (MyClass f1, MyClass f2)  
            {
                return new MyClass();
            }

            public static void Main()
            {
                MyClass f = new MyClass();
                int i = f && f;
            }
        }
    }
}
