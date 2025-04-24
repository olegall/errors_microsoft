
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0310
    {
        class G<T> where T : new()
        {
            T t;

            public G()
            {
                t = new T();
                Console.WriteLine(t);
            }
        }

        class B
        {
            private B() { }
            // Try this instead:  
            // public B() { }  
        }

        class CMain
        {
            public static void Main()
            {
                G<B> g = new G<B>();   // CS0310  
                Console.WriteLine(g.ToString());
            }
        }
    }
}
