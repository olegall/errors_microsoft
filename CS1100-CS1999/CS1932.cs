// CS1932.cs  
using System.Linq;
class Test
{
    static void Main()
    {

        var x = from i in Enumerable.Range(1, 100)
                let k = null // CS1932  
                // Try the following line instead.  
                let k = (string)null
                select i;
    }
}