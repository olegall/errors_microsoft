
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0275
    {
        // CS0275.cs  
        public interface MyInterface
        {
            int Property
            {
                get;
                internal set;   // CS0275  
            }
        }
    }
}
