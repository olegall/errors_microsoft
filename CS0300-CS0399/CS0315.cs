using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0315
    {
        // cs0315.cs  
        public class ClassConstraint { }
        public struct ViolateClassConstraint { }

        public class Gen<T> where T : ClassConstraint
        {
        }
        public class Test
        {
            public static int Main()
            {
                Gen<ViolateClassConstraint> g = new Gen<ViolateClassConstraint>(); //CS0315  
                return 1;
            }
        }
    }
}
