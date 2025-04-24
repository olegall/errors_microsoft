
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0071
    {
        // CS0071.cs
        public delegate void MyEvent(object sender);

        interface ITest
        {
            event MyEvent Clicked;
        }

        class Test : ITest
        {
            event MyEvent ITest.Clicked;  // CS0071

            // Try the following code instead.
            /*
            private MyEvent clicked;

            event MyEvent ITest.Clicked
            {
                add
                {
                    clicked += value;
                }
                remove
                {
                    clicked -= value;
                }
            }
            */
            public static void Main() { }
        }
    }
}
