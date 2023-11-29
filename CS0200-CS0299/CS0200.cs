using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0200
    {
        // CS0200.cs
        public class Example
        {
            private int _mi;
            int I
            {
                get
                {
                    return _mi;
                }
                // uncomment the set accessor and declaration for _mi
                /*
                set
                {
                    _mi = value;
                }
                */
            }

            public static void Main()
            {
                Example example = new Example();
                example.I = 9;   // CS0200
            }
        }
    }
}
