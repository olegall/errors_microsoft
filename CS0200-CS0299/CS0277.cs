
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0277
    {
        // CS0277.cs  
        public interface MyInterface
        {
            int Property
            //public int Property
            {
                get;
                set;
            }
        }

        public class MyClass : MyInterface   // CS0277  
        {
            public int Property
            {
                get { return 0; }
                // Try this instead:  
                //set { }  
                protected set { }
            }
        }
    }
}
