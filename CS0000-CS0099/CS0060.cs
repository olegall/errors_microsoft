
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0060
    {
        // CS0060.cs  
        class MyClass
        // try the following line instead  
        // public class MyClass  
        {
        }

        public class MyClass2 : MyClass   // CS0060  
        {
            public static void Main()
            {
            }
        }
    }
}
