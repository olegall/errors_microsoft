using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0509
    {
        // CS0509.cs  
        // compile with: /target:library  
        sealed public class clx { }
        public class cly : clx { }   // CS0509  
    }
}
