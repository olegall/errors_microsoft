using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0524
    {
        // CS0524.cs  
        public interface Clx
        {
            public class Cly   // CS0524, delete user-defined type  
            {
            }
        }
    }
}
