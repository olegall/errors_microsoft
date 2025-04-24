
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal partial class CS0686
    {
        // CS0686.cs  
        interface I
        {
            int get_P();
        }

        class C : I
        {
            public int P
            {
                get { return 1; }  // CS0686  
            }
        }
        // But the following is valid:  
        class D : I
        {
            int I.get_P() { return 1; }
            public static void Main() { }
        }

        interface I
        {
            void add_OnMyEvent(EventHandler e);
        }

        class C : I
        {
            public event EventHandler OnMyEvent
            {
                add { }  // CS0686  
                remove { }
            }
        }

        // Correct (using explicit interface implementation):  
        class D : I
        {
            void I.add_OnMyEvent(EventHandler e) { }
            public static void Main() { }
        }
    }
}