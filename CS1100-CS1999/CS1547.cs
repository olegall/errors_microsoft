
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1547
    {
        // CS1547.cs  
        public class MyClass
        {
            void BadMethod()
            {
                void i;   // CS1547, cannot have variables of type void  
            }

            public static void Main()
            {
            }
        }
    }
}
