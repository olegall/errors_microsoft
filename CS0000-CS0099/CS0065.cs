using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0065
    {
        public delegate void EventHandler(object sender, int e);
        public class MyClass
        {
            public event EventHandler Click   // CS0065,
            {
                // to fix, uncomment the add and remove definitions
                /*
                add
                {
                   Click += value;
                }
                remove
                {
                   Click -= value;
                }
                */
            }
            
            public static void Main()
            {
            }
        }
    }
}
