
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0709
    {
        // CS0709.cs  
        // compile with: /target:library  
        public static class Base { }
        public class Derived : Base { }   // CS0709
    }
}
