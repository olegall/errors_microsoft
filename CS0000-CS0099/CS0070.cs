using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0070
    {
        public delegate void EventHandler();

        public class A
        {
            public event EventHandler Click;

            public static void OnClick()
            {
                EventHandler eh;
                A a = new A();
                eh = a.Click;
            }

            public static void Main()
            {
            }
        }

        public class B
        {
            public int Foo()
            {
                EventHandler eh = new EventHandler(A.OnClick);
                A a = new A();
                eh = a.Click;   // CS0070  
                                // try the following line instead  
                                // a.Click += eh;  
                return 1;
            }
        }
    }
}
