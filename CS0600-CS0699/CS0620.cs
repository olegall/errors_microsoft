using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0620
    {
        public static void Main()
        {
            MyClass test = new MyClass();
            System.Console.WriteLine(test[2]);
        }

        void this[int intI]   // CS0620, return type cannot be void  
        {
            get
            {
                // will need to return some value  
            }
        }
    }
}
