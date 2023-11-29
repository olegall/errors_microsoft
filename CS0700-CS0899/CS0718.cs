using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0718
    {
        // CS0718.cs  
        public static class SC
        {
            public static void F()
            {
            }
        }

        public class G<T>
        {
        }

        public class CMain
        {
            public static void Main()
            {
                G<SC> gsc = new G<SC>();  // CS0718  
            }
        }
    }
}
