using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0267
    {
        public partial class MyClass
        {
        }

        partial public class MyClass  // CS0267
        // Try this line instead:
        // public partial class MyClass
        {
        }
    }
}
