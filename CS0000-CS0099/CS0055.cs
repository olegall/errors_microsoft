
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0055
    {
        // CS0055.cs  
        class MyClass //defaults to private accessibility  
        // try the following line instead  
        // public class MyClass  
        {
        }

        public class MyClass2
        {
            public int this[MyClass myClass]   // CS0055  
            {
                get
                {
                    return 0;
                }
            }
        }

        public class MyClass3
        {
            public static void Main()
            {
            }
        }
    }
}
