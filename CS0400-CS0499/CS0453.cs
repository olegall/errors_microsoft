using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0453
    {
        public class HV<S> where S : struct { }

        // CS0453: string is not a value type
        public class H1 : HV<string> { }

        // CS0453: H1 is a class, not a struct
        public class H2 : HV<H1> { }

        // CS0453: HV is based on a class, not a struct
        public class H3<S> : HV<S> where S : class { }
        public class H4<S> : HV<S> where S : struct { } // OK

        // CS0453: HV accepts a nullable int type
        public class H4 : HV<int?> { }

        // CS0453: HV is based on Nullable type of int
        public class H5 : HV<Nullable<Nullable<int>>> { }
    }
}
