using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0146
    {
        public interface InterfaceA
        {
        }

        public class MyClass : InterfaceA, MyClass2
        {
            public void Main()
            {
            }
        }

        public class MyClass2 : MyClass   // CS0146  
        {
        }
    }
}
