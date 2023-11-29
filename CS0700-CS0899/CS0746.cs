using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS0700_CS0799
{
    internal class CS0746
    {
        public static int Main()
        {
            int i = 100;
            string s = "Bottles of beer.";

            var incorrect_1 = new { a.b = 1 }; // CS0746
            var incorrect_2 = new { 100, "Bottles of beer." }; // CS0746  
            var correct_1 = new { i, s }; //OK  
            var correct_2 = new { num = i, message = s }; // OK  

            return 1;
        }
    }
}
