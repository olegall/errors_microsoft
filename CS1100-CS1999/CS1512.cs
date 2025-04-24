
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1512
    {
        // CS1512.cs  

        class Base { }

        class CMyClass : Base
        {
            private String xx = base.ToString();   // CS1512  
                                                   // Try putting this initialization in the constructor instead:  
            // public CMyClass()  
            // {  
            //    xx = base.ToString();  
            // }  

            public static void Main()
            {
                CMyClass z = new CMyClass();
            }
        }
    }
}
