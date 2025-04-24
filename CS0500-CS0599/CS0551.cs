
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0551
    {
        // CS0551.cs  
        // compile with: /target:library  
        interface ii
        {
            int i
            {
                get;
                set;
            }
        }

        public class a : ii
        {
            int ii.i { set { } }   // CS0551  

            // OK  
            int ii.i
            {
                set { }
                get { return 0; }
            }
        }
    }
}
