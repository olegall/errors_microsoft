
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0069
    {
        public delegate void EventHandler();

        public interface a
        {
            event EventHandler Click { remove { } }   // CS0069  
            event EventHandler Click2 { add { } remove { } }   // CS0069  
            event EventHandler Click3;   // OK  
        }
    }
}
