
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0068
    {
        // CS0068.cs  

        delegate void MyDelegate();

        interface I
        {
            event MyDelegate d = new MyDelegate(M.f);   // CS0068  
            // try the following line instead  
            // event MyDelegate d2;
        }

        class M
        {
            event MyDelegate d = new MyDelegate(M.f);
            //event MyDelegate d2 = new MyDelegate();

            public static void f()
            {
            }

            public static void Main()
            {
            }
        }
    }
}
