
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1106
    {
        // CS1106.cs
        public class NonStaticClass // CS1106
        {
            public static void ExtensionMethod1(this int num) { }
        }

        public static class StaticGenericClass<T> // CS1106
        {
            public static void ExtensionMethod2(this int num) { }
        }

        public static class StaticClass // OK
        {
            public static void ExtensionMethod3(this int num) { }
        }
    }
}
