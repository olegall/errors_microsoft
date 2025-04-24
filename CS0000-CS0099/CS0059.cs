
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0059
    {
        // CS0059.cs  
        class MyClass //defaults to private accessibility  
        // try the following line instead  
        // public class MyClass  
        {
        }

        public delegate void MyClassDel(MyClass myClass);   // CS0059  

        public class Program
        {
            public static void Main()
            {
            }
        }
    }
}
