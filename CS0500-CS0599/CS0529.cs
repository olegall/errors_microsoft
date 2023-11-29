using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0529
    {
        public interface a
        {
        }

        public interface b : a, c
        {
        }

        public interface c : b   // CS0529, b inherits from c  
        {
        }
    }
}
