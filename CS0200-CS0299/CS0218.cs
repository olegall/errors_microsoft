
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0218
    {
        // CS0218.cs  

        public class MyClass
        {
            // uncomment these operator declarations to resolve this CS0218  
            /*  
            public static bool operator true (MyClass f)  
            {  
               return false;  
            }  

            public static bool operator false (MyClass f)  
            {  
               return false;  
            }  
            */

            public static implicit operator int(MyClass x)
            {
                return 0;
            }

            public static MyClass operator &(MyClass f1, MyClass f2)
            {
                return new MyClass();
            }

            public static void Main()
            {
                MyClass f = new MyClass();
                int i = f && f;   // CS0218, requires operators true and false  
            }
        }
    }
}
