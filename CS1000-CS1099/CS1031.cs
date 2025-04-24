
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1031
    {
        public class ii
        {
        }

        public class a
        {
            public static operator +(a aa)   // CS1031  
            // try the following line instead  
            // public static ii operator +(a aa)  
            {
                return new ii();
            }

            public static void Main()
            {
                e = new base;   // CS1031, not a type  
                e = new this;   // CS1031, not a type  
                e = new();     // CS1031, not a type  
                var a1 = new();
            }
        }
    }
}