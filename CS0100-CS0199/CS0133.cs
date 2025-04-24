
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0133
    {
        // CS0133.cs  
        public class MyClass
        {
            public const int i = c;   // CS0133, c is not constant  
            public static int c = i;
            // try the following line instead  
            // public const int i = 6;  

            public static void Main()
            {
            }
        }
    }
}
