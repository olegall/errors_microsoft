using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0452
    {
        public class BaseClass<S> where S : class { }
        public class Derived1 : BaseClass<int> { } // CS0452  
        public class Derived2<S> : BaseClass<S> where S : struct { } // CS0452 
        public class Derived3<S2> : BaseClass<S2> where S2 : struct { } // CS0452 
        public class Derived4<S2> : BaseClass<S2> where S2 : class { }
    }
}
