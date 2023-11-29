using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0717
    {
        // CS0717.cs  

        public static class SC
        {
            public static void F()
            {
            }
        }

        public class G<T> where T : SC  // CS0717  
        {
            public static void Main()
            {
            }
        }
    }
}
