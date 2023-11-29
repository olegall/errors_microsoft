using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0721
    {
        // CS0721.cs  
        public static class SC
        {
        }

        public class CMain
        {
            public void F(SC sc)  // CS0721  
            {
            }

            public static void Main()
            {
            }
        }
    }
}
