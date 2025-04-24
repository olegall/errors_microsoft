
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1105
    {
        // cs1105.cs  
        // Compile with: /target:library  
        public class Extensions
        {

            // Single type parameter.  
            public void Test<T>(this System.String s) { } //CS1105  

        }
    }
}
