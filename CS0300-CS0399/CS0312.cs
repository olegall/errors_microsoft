
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0312
    {
        // cs0312.cs  
        class Program
        {
            static void MTyVar<T, U>() where T : U { }

            static int Main()
            {
                MTyVar<int?, int>(); // CS0312  
                return 1;
            }
        }
    }
}
