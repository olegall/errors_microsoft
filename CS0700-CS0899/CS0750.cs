
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0750
    {
        public class Base
        {
            protected virtual void PartG()
            {
            }

            protected void PartH()
            {
            }
            protected virtual void PartI()
            {
            }
        }

        public partial class C : Base
        {
            // All these partial method declarations  
            // will generate CS0750.  
            public partial void PartA();
            private partial void PartB();
            protected partial void PartC();
            internal partial void PartD();
            virtual partial void PartE();
            abstract partial void PartF();
            override partial void PartG();
            new partial void PartH();
            sealed override partial void PartI();
            extern partial void PartJ();

            public static int Main()
            {
                return 1;
            }
        }
    }
}
