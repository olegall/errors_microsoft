using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0500_CS0599
{
    internal class CS0592
    {
        // CS0592.cs  


        [AttributeUsage(AttributeTargets.Interface)]
        public class MyAttribute : Attribute
        {
        }

        [MyAttribute]
        // Generates CS0592 because MyAttribute is not valid for a class.
        public class A
        {
            public static void Main()
            {
            }
        }
    }
}
