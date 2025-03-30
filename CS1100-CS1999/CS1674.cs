using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CS1674
{
    // CS1674.cs  
    class C
    {
        public static void Main()
        {
            int a = 0;
            a++;

            using (a) { }   // CS1674  
        }
    }

    // CS1674_b.cs  
    class C2
    {
        public void Test()
        {
            using (C2 c = new C2()) { }   // CS1674  
        }
    }

    // OK  
    class D : IDisposable
    {
        void IDisposable.Dispose() { }
        public void Dispose() { }

        public static void Main()
        {
            using (D d = new D()) { }
        }
    }

    // CS1674_c.cs  
    // compile with: /target:library  
    public class C<T>
    // Add a class type constraint that specifies a disposable class.  
    // Uncomment the following line to resolve.  
    // public class C<T> where T : IDisposable  
    {
        public void F(T t)
        {
            using (t) { }   // CS1674  
        }
    } 
}