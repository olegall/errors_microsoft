using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1044
    {
        // CS1044.cs  
        public class MyClass2 { }

        public class MyClass : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Res1.Dispose()");
            }

            public static void Main()
            {
                using (MyClass mc1 = new MyClass(), MyClass mc2 = new MyClass())   // CS1044, remove an instantiation  
                //using (MyClass mc1 = new MyClass(), MyClass2 mc2 = new MyClass2())   // CS1044, remove an instantiation  
                {
                }
            }
        }
    }
}