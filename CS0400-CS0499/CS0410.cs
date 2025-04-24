
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0410
    {
        // CS0410.cs
        // compile with: /langversion:ISO-1

        class Test
        {
            delegate void D(double d);
            static void F(int i) { }
            
            //delegate void D(int d); // автоматического каста в делегатах нет
            //static void F(double i) { }

            static void Main()
            {
                D d = new D(F);  // CS0410
            }
        }
    }
}
