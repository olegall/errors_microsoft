using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0245
    {
        class MyClass // : IDisposable  
        {
            /*  
            public void Dispose()  
            {  
               // cleanup code goes here  
            }  
            */

            void m()
            {
                this.Finalize();   // CS0245  
                                   // this.Dispose();  
            }

            public static void Main()
            {
            }
        }
    }
}
