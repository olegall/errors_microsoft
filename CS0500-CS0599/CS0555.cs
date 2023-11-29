using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0555
    {
        // delete the following operator to resolve this CS0555
        public static implicit operator MyClass(MyClass aa)   // CS0555
        {
            return new MyClass();
        }

        public static void Main()
        {
        }
    }
}
