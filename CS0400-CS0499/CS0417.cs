using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0417
    {
        // CS0417  
        class ExampleClass<T> where T : new()
        {
            // The following line causes CS0417.  
            T instance1 = new T(1);

            // The following line doesn't cause the error.  
            T instance2 = new T();
        }
    }
}
