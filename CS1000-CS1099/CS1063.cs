
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1063
    {
        class Test
        {
            public static void Main()
            {
                B coll = new B { "a" };
                var coll2 = new B2 { "a" };
            }
        }

        public class B : IEnumerable
        {
            [Obsolete("Don't use this overload", true)]
            public void Add(string s)
            {
                //...
            }
            public void Add(int i)
            {
                //...
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        public class B2 : IEnumerable
        {
            public void Add(string s)
            {
                //...
            }
            public void Add(int i)
            {
                //...
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return null;
            }
        }
    }
}