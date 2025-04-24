
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0160
    {
        // CS0160.cs  
        public class MyClass2 : System.Exception { }
        public class MyClass
        {
            public static void Main()
            {
                try { }

                catch (System.Exception) { }   // Second-most derived; should be second catch
                catch (MyClass2) { }   // CS0160  Most derived; should be first catch
            }
        }
    }
}
