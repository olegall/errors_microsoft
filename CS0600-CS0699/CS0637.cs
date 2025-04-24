
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0637
    {
        // CS0637.cs  

        [StructLayout(LayoutKind.Explicit)]
        public class MainClass
        {
            [FieldOffset(3)]   // CS0637  
            public static int i;
            public static void Main()
            {
            }
        }
    }
}
