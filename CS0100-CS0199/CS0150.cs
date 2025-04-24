
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0150
    {
        delegate string MyDelegate(int i);

        public class MyClass
        {
            public static void Main()
            {
                int i = 0;
                int j = 0;

                switch (i)
                {
                    case j:   // CS0150, j is a variable int, not a constant int  
                              // try the following line instead  
                              // case 0:  
                }
            }
        }
    }
}
