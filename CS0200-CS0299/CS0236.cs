
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0236
    {
        public class MyClass
        {
            public int i = 5;
            //static int i = 5;

            // To fix the error, remove "= i", and uncomment the line in constructor.
            //public int j = i;  // CS0236
            public int j;

            public MyClass()
            //public static MyClass()
            //static MyClass()
            {
                // Uncomment the following.
                //j = i;
            }
        }
    }
}
