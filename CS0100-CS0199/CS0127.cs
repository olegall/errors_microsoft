
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0127
    {
        public class MyClass
        {
            public int hiddenMember2
            {
                get
                {
                    return 0;
                }
                set   // CS0127, set has an implicit void return type  
                {
                    return 0;   // remove return statement to resolve this CS0127  
                }
            }

            public static void Main()
            {
            }
        }
    }
}
