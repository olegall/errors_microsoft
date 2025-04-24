
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0535
    {
        // CS0535.cs  
        public interface A
        {
            void F();
        }

        public class B : A { }   // CS0535 A::F is not implemented  

        // OK  
        public class C : A
        {
            public void F() { }
            public static void Main() { }
        }
        
        public abstract class C2 : A
        {
            public abstract void F();
        }
    }
}
