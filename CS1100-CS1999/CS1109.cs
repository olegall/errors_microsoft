
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1109
    {
        // cs1109.cs  
        public class Test
        {
        }
        static class Out
        {
            static class Extension
            {
                static void ExtMethod(this Test c) // CS1109  
                {
                }
            }
        }
    }
}
