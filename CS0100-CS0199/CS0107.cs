
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0106
    {
        // CS0107.cs
        public class C
        {
            private internal void F()   // CS0107, delete private or internal
            {
            }
        }
    }
}
