
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0513
    {
        public class clx
        {
            abstract public void f();   // CS0513, abstract member of nonabstract class  
        }

        abstract class clx2
        {
            public void f() { }
        }
    }
}
