using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0533
    {
        abstract public class a
        {
            abstract public void f();
        }

        abstract public class b : a
        {
            new abstract public void f();   // CS0533  
            // try the following lines instead  
            // override public void f()  
            // {  
            // }  

            public static void Main()
            {
            }
        }
    }
}
