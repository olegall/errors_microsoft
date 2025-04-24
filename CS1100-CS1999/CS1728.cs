
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1728
    {
        // CS1728.cs  
        class Test
        {
            delegate T GetT<T>();
            delegate T GetT1<T>(T t);

            delegate bool E(object o);
            delegate int I();
            delegate string S();

            static void Main()
            {
                int? x = null;
                int? y = 5;

                GetT<int> d1 = x.GetValueOrDefault;   // CS1728  
                GetT<int> d2 = y.GetValueOrDefault;   // CS1728  
                GetT1<int> d3 = x.GetValueOrDefault;   // CS1728  
                GetT1<int> d4 = y.GetValueOrDefault;   // CS1728  
            }
        }
    }
}