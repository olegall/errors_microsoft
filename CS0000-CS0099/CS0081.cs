
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0081
    {
        // CS0081.cs  
        class MyClass
        {
            public void F<int>() { }   // CS0081  
            public void F<T>(T input) { }   // OK  

            public static void Main()
            {
                MyClass a = new MyClass();
                a.F<int>(2);
                a.F<double>(.05);
            }
        }
    }
}
