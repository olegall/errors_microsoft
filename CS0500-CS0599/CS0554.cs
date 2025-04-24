
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0554
    {
        public class ii
        {
            // delete the conversion routine to resolve CS0554  
            public static implicit operator ii(a aa) // CS0554  
            {
                return new ii();
            }
        }

        public class a : ii
        {
            public static void Main()
            {
            }
        }
    }
}
