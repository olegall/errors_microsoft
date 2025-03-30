using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0507
    {
        // CS0507.cs  
        abstract public class clx
        {
            virtual protected void f() { }
        }

        public class cly : clx
        {
            public override void f() { }   // CS0507  
            public static void Main() { }
        }

        // CS0507_b.cs  
        // compile with: /target:library  
        abstract public class clx
        {
            virtual protected internal void f() { }
        }

        // CS0507_c.cs  
        // compile with: /reference:cs0507_b.dll  
        public class cly : clx
        {
            protected internal override void f() { }   // CS0507  
            //private internal override void f() { }
            //public internal override void f() { }
            // try the following line instead  
            // protected override void f() {}   // OK  

            public static void Main() { }
        }
    }
}
