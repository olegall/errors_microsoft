using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{

    internal class CS0066
    {
        public class EventHandler
        {
        }

        // to fix the error, remove the event declaration and the  
        // EventHandler class declaration, and uncomment the following line  
        // public delegate void EventHandler();  

        public class a
        {
            public event EventHandler Click;   // CS0066  

            private void TestMethod()
            {
                if (Click != null)
                    Click();
            }

            public static void Main()
            {
            }
        }
    }
}
