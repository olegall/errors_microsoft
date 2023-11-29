using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0545
    {
        // CS0545.cs  
        // compile with: /target:library  
        // CS0545  
        public class a
        {
            public virtual int i
            {
                set { }

                // Uncomment the following line to resolve.  
                // get { return 0; }  
            }
        }

        public class b : a
        {
            public override int i
            {
                get { return 0; }
                set { }   // OK  
            }
        }
    }
}
