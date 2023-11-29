using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0075
    {
        enum MyEnum { }
        public class MyClass
        {
            public static void Main()
            {
                // To fix the error, place the negative  
                // values below in parentheses  
                int i = (System.Int32) - 4; //CS0075  
                MyEnum e = (MyEnum) - 1;    //CS0075  
                System.Console.WriteLine(i); //to avoid warning  
                System.Console.WriteLine(e); //to avoid warning  
            }
        }
    }
}
