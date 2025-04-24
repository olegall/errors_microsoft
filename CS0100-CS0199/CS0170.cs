
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0170
    {
        // CS0170.cs  
        public struct error
        {
            public int i;
            //public int i = 0;
        }

        public class MyClass
        {
            public static void Main()
            {
                error e;
                // uncomment the next line to resolve this error  
                // e.i = 0;  
                System.Console.WriteLine(e.i);   // CS0170 because
                                                 //e.i was never assigned  
            }
        }
    }
}
