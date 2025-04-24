
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0713
    {
        // CS0713.cs  
        public class Base
        {
        }

        public static class Derived : Base  // CS0713  
        {
        }

        public class CMain
        {
            public static void Main()
            {
            }
        }
    }
}
