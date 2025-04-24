
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0715
    {
        // CS0715.cs  
        public static class C
        {
            public static C operator +(C c)  // CS0715  
            {
            }

            public static void Main()
            {
            }
        }
    }
}
