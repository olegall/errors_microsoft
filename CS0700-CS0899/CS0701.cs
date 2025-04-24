
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0701
    {
        // CS0701.cs  
        // compile with: /target:library  
        class C<T> where T : System.String { }   // CS0701  
        class D<T> where T : System.Attribute { }   // OK 
    }
}
