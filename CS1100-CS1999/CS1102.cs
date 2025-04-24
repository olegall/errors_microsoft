
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1102
    {
        // cs1102.cs  
        // Compile with: /target:library.  
        public static class Extensions
        {
            // No type parameters.  
            public static void Test(this out int i) { } // CS1102  

            //Single type parameter  
            public static void Test<T>(this out T t) { }// CS1102  

            //Multiple type parameters  
            public static void Test<T, U, V>(this out U u) { }// CS1102  
        }
    }
}
