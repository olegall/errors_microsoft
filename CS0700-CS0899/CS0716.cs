
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0716
    {
        // CS0716.cs  

        public static class SC
        {
            static void F() { }
        }

        public class Test
        {
            public static void Main()
            {
                object o = new object();
                System.Console.WriteLine((SC)o);  // CS0716  
            }
        }
    }
}
