
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0571
    {
        public static MyClass operator ++(MyClass c)
        {
            return null;
        }

        public static int prop
        {
            get
            {
                return 1;
            }
            set
            {
            }
        }

        public static void Main()
        {
            op_Increment(null);   // CS0571  
                                  // use the increment operator as follows  
                                  // MyClass x = new MyClass();  
                                  // x++;  

            set_prop(1);      // CS0571  
                              // try the following line instead  
                              // prop = 1;  
        }
    }
}
