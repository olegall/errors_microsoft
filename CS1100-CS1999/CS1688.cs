
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CS1688
{
    delegate void OutParam(out int i);
    class ErrorCS1676
    {
        static void Main()
        {
            OutParam o;
            o = delegate  // CS1688  
            // Try this instead:  
            // o = delegate(out int i)  
            {
                Console.WriteLine("");
            };
        }
    }
}