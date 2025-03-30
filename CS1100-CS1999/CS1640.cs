using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1640 
    {
        public class C : IEnumerable, IEnumerable<int>, IEnumerable<string>
        {
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                yield break;
            }

            IEnumerator<string> IEnumerable<string>.GetEnumerator()
            {
                yield break;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)((IEnumerable<string>)this).GetEnumerator();
            }
        }

        public class Test
        {
            public static int Main()
            {
                foreach (int i in new C()) { }    // CS1640  

                // Try specifying the type of IEnumerable<T>  
                // foreach (int i in (IEnumerable<int>)new C()){}  
                return 1;
            }
        }
    }
}
