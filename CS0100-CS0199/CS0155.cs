
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0155
    {
        public class MyClass2
        // try the following line instead  
        // public class MyClass2 : Exception  
        {
        }
        public class MyClass
        {
            public static void Main()
            {
                try
                {
                }
                catch (MyClass2)   // CS0155, resolves if you derive MyClass2 from Exception  
                {
                }
            }
        }
    }
}
