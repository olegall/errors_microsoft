using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0080
    {
        public class MyClass where MyClass : System.IDisposable // CS0080    //the following line shows an example of correct syntax  
        //public class MyClass<T> where T : System.IDisposable  
        {
            public void Foo() where Foo : new() // CS0080  
            //the following line shows an example of correct syntax  
            //public void Foo<U>() where U : struct  
            {
            }
        }

        public class Program
        {
            public static void Main()
            {
            }
        }
    }
}
