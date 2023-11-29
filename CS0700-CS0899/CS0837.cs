using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0837
    {
        public delegate void Del();

        public delegate void Del2();

        public void Foo1() { }

        class Test
        {
            static int Main()
            {
                bool b1 = (() => { }) is Del;   // CS0837
                bool b2 = delegate () { } is Del;// CS0837
                Del d1 = () => { } as Del;      // CS0837  
                Del d2 = delegate () { } as Del; // CS0837

                bool b3 = Del2 is Del;
                bool b4 = Foo1 is Del;

                return 1;
            }
        }
    }
}
