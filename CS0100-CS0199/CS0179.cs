
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0179
    {
        // CS0179.cs  
        public class MyClass
        {
            public extern int ExternMethod(int aa)   // CS0179  
            {
                return 0;
            }
            // try the following line instead  
            // public extern int ExternMethod(int aa);  

            public static void Main()
            {
            }
        }
    }
}
