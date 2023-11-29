using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0644
    {
        // CS0644.cs  
        class MyClass : System.ValueType   // CS0644  
        {
        }
        
        class MyClass : System.Enum   // CS0644  
        {
        }
        
        class MyClass : System.Delegate   // CS0644  
        {
        }
        
        class MyClass : System.Array   // CS0644  
        {
        }
    }
}
