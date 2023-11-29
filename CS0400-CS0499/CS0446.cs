using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0446
    {
        // CS0446.cs  

        class Tester
        {
            static void Main()
            {
                int[] intArray = new int[5];
                foreach (int i in M) { } // CS0446  
            }
            static void M() { }
        }
    }
}
