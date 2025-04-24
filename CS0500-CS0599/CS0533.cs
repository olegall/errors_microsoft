
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
            //virtual public void f() { }
        }

        abstract public class b : a
        {
            new abstract public void f();   // CS0533  
            //override public void f(){}  // try the following lines instead

            public static void Main()
            {
            }
        }
    }
}
