using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0316
    {
        // cs0316.cs  
        // Compile with: /target:library  
        public class Test
        {
            public int this[int value] // CS0316  
            {
                get { return 1; }
                set { }
            }
        }
    }
}
