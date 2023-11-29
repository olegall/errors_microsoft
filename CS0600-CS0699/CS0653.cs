using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0653
    {
        public abstract class MyAttribute : Attribute
        {
        }

        public class My2Attribute : MyAttribute
        {
        }

        [My]   // CS0653  
        // try the following line instead  
        // [My2]
        class MyClass
        {
            public static void Main()
            {
            }
        }
    }
}
