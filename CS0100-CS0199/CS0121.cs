
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    // CS0120_1.cs
    internal class CS0121
    {
        public class Program
        {
            static void f(int i, double d)
            {
            }

            static void f(double d, int i)
            {
            }

            public static void Main()
            {
                f(1, 1);   // CS0121

                // Try the following code instead:
                // f(1, 1.0);
                // or
                // f(1.0, 1);
                // or
                // f(1, (double)1);   // Cast and specify which method to call.
                // or
                // f(i: 1, 1);
                // or
                // f(d: 1, 1);

                // f(i: 1, d: 1); // This still gives CS0121
            }
        }
    }
}
