
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1622 
    {
        class C : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return (IEnumerator)this;  // CS1622  
                yield return this;   // OK  
            }
        }
    }
}
