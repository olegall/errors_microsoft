
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0825
    {
        // cs0825.cs  
        class Test
        {
            // Both of these declarations trigger CS0825
            private var genreName;
            private var bookTitles = new List<string>();

            static int Main()
            {
                var totalBooks = 42; // var is OK here  
                return -1;
            }
        }
    }
}
