using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0136
    {
        public class MyClass
        {
            public static void Main()
            {
                int i = 0;
                {
                    char i = 'a';   // CS0136, hides int i  
                }
                //int i = 0;
                i++;
            }
        }
    }
}
