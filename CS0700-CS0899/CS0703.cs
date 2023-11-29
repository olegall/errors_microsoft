using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0703
    {
        // CS0703.cs  
        internal interface I { }
        public class C<T> where T : I  // CS0703 – I is internal; C<T> is public  
        {
        }
    }
}
