
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0057
    {
        // CS0057.cs  
        class MyClass //defaults to private accessibility  
        // try the following line instead  
        // public class MyClass  
        {
        }

        public class MyClass2
        {
            public static implicit operator MyClass2(MyClass iii)   // CS0057  
            {
                return new MyClass2();
            }

            public static void Main()
            {
            }
        }
    }
}
