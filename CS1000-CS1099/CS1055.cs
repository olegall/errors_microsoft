using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1000_CS1100
{
    internal class CS1055
    {
        // CS1055.cs  
        delegate void del();
        class Test
        {
            public event del MyEvent
            {
                int i;   // CS1055  
                // uncomment accessors and delete previous line to resolve  
                //add
                //{
                //    MyEvent += value;
                //}
                //remove
                //{
                //    MyEvent -= value;
                //}
            }

            public static void Main()
            {
            }
        }
    }
}