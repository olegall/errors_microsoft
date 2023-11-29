using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0082
    {
        //cs0082.cs  
        class MyClass
        {

            //property  
            public int MyProp
            {
                get //CS0082  
                {
                    return 1;
                }
            }

            //conflicting Get  
            public int get_MyProp()
            {
                return 2;
            }

            public static int Main()
            {
                return 1;
            }
        }
    }
}
