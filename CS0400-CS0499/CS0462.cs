
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0462
    {
        // CS0462.cs  
        // compile with: /target:library  
        class C<T>
        {
            public virtual void F(T t) { }
            public virtual void F(int t) { }
            //public virtual void F(double t) { }
        }

        class D : C<int>
        {
            public override void F(int t) { }   // CS0462  
        }
    }
}
