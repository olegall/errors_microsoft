using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0400_CS0499
{
    internal class CS0425
    {
        // CS0425.cs  

        class C1
        {
        }

        class C2
        {
        }

        interface IBase
        {
            void F<ItemType>(ItemType item) where ItemType : C1;
        }

        class Derived : IBase
        {
            public void F<ItemType>(ItemType item) where ItemType : C2  // CS0425  
            {
            }
        }

        class CMain
        {
            public static void Main()
            {
            }
        }
    }
}
