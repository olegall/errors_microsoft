
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0457
    {
        public class A { }

        public class G0 { }
        public class G1<R> : G0 { }

        public class H0
        {
            public static implicit operator G0(H0 h)
            {
                return new G0();
            }
        }
        public class H1<R> : H0
        {
            public static implicit operator G1<R>(H1<R> h)
            {
                return new G1<R>();
            }
        }

        public class Test
        {
            public static void F0(G0 g) { }
            public static void Main()
            {
                H1<A> h1a = new H1<A>();
                F0(h1a);   // CS0457  
            }
        }
    }
}
