using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0185
    {
        struct A { }
        // CS0185.cs  
        public class MainClass
        {
            public static void Main()
            {
                lock (1)   // CS0185  
                // try the following lines instead  
                // MainClass x = new MainClass();  
                // lock(x)  
                //var a = new A();
                //lock(a)
                {}
            }
        }
    }
}
