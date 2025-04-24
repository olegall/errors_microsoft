
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1912
    {
        // cs1912.cs  
        public class TestClass
        {
            public int memberA { get; set; }
            public int memberB { get; set; }
        }

        public class Test
        {
            static void Main()
            {
                TestClass tc = new TestClass() { memberA = 5, memberA = 6, memberB = 2 }; // CS1912  
            }
        }
    }
}