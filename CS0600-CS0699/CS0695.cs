
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal partial class CS0695
    {
        // CS0695.cs  
        // compile with: /target:library  

        interface I<T>
        {
        }

        class G<T1, T2> : I<T1>, I<T2>  // CS0695  
        {
        }
    }
}