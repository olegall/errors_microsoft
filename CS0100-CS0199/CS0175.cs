
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0175
    {
        class BaseClass
        {
            public int TestInt = 0;
        }

        class MyClass : BaseClass
        {
            public static void Main()
            {
                MyClass aClass = new MyClass();
                aClass.BaseTest();
            }

            public void BaseTest()
            {
                Console.WriteLine(base); // CS0175  
                                         // Try the following line instead:  
                                         // Console.WriteLine(base.TestInt);  
                base = 9;   // CS0175  

                // Try the following line instead:  
                // base.TestInt = 9;  
            }
        }
    }
}
