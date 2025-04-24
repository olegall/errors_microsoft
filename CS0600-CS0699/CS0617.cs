
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0600_CS0699
{
    internal class CS0617
    {
        [AttributeUsage(AttributeTargets.Struct |
                AttributeTargets.Class |
                AttributeTargets.Interface)]
        public class MyClass : Attribute
        {
            public int Name;

            public MyClass(int sName)
            {
                Name = sName;
                Bad = -1;
                Bad2 = -1;
            }

            public readonly int Bad;
            public int Bad2;
        }

        [MyClass(5, Bad = 0)] class Class1 { }   // CS0617  
        [MyClass(5, Bad2 = 0)] class Class2 { }
    }
}
