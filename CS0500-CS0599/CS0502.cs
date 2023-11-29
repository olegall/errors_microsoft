using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0502
    {
        // CS0502.cs  
        public class B
        {
            abstract public void F();
        }

        public class C : B
        {
            abstract sealed override public void F()   // CS0502  
            {
            }
        }

        public class CMain
        {
            public static void Main()
            { }
        }
    }
}
