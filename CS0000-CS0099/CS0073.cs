﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0073
    {
        // CS0073.cs  
        delegate void del();

        class Test
        {
            public event del MyEvent
            {
                add;   // CS0073  
                // try the following lines instead  
                // add  
                // {  
                //    MyEvent += value;  
                // }  
                //add { }
                remove
                {
                    MyEvent -= value;
                }

            }
            //public event del MyEvent;
            //public event del MyEvent { };
            public static void Main()
            {
            }
        }
    }
}
