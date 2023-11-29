using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0072
    {
        // CS0072.cs
        delegate void MyDelegate();

        class Test1
        {
            public virtual event MyDelegate MyEvent;
            public virtual void VMeth()
            {
            }

            public void FireAway()
            {
                if (MyEvent != null)
                    MyEvent();
            }
        }

        class Test2 : Test1
        {
            public override event MyDelegate VMeth   // CS0072
                                                     // Uncomment the following lines to resolve.
                                                     // public override event MyDelegate MyEvent
            {
                add
                {
                    VMeth += value;
                    // MyEvent += value;
                }
                remove
                {
                    VMeth -= value;
                    // MyEvent -= value;
                }
            }

            public static void Main()
            {
            }
        }
    }
}
