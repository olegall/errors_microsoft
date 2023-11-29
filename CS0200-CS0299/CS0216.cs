using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors
{
    internal class CS0216
    {
        // CS0216.cs  
        class MyClass
        {
            public static bool operator ==(MyClass MyIntLeft, MyClass MyIntRight)   // CS0216  
            {
                return MyIntLeft == MyIntRight;
            }

            // to resolve, uncomment the following operator definition  

            //public static bool operator !=(MyClass MyIntLeft, MyClass MyIntRight)
            //{
            //    return MyIntLeft != MyIntRight;
            //}


            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public static void Main()
            {
            }
        }
    }
}
