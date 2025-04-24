
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0205
    {
        // CS0205.cs  
        abstract public class MyClass
        {
            abstract public void M();
        }

        public class MyClass2 : MyClass
        {
            public override void M()
            {
                base.M();   // CS0205, delete this line  
            }

            public static void Main()
            {
            }
        }
    }
}
