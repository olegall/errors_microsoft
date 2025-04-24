
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0314
    {
        // cs0314.cs  
        // Compile with: /target:library  
        public class ClassConstraint { }

        public class A<T> where T : ClassConstraint
        { }

        public class B<T> : A<T> //CS0314  
        { }

        // Try using this instead.  
        public class C<T> : A<T> where T : ClassConstraint
        { }
    }
}
