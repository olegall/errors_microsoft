
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0300_CS0399
{
    internal class CS0304
    {
        //class C<T> where T : new()

        //// CS0304.cs  
        //// Compile with: /target:library.  
        //class C<T>
        //{
        //    // The following line generates CS0304.  
        //    T t = new T();
        //}

        // Compile with: /target:library.  
        class C<T>
        //class C<T> where T : new()
        {
            public void ExampleMethod()
            {
                // The following line generates CS0304.  
                T t = new T();
            }
        }

        //// Compile with: /target:library.  
        //class C<T> where T : new()
        //{
        //    T t = new T();

        //    public void ExampleMethod()
        //    {
        //        T t = new T();
        //    }
        //}
    }
}
