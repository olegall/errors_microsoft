// cs1938.cs  
using System.Linq;
class Test
{
    static void Main()
    {
        int[] sourceA = { 1, 2, 3, 4, 5 };
        int[] sourceB = { 3, 4, 5, 6, 7 };

        var query = from a in sourceA
                    join b in sourceB on b equals a // CS1938  
                    // Try the following line instead.  
                    // join b in sourceB on a equals b  
                    select new { a, b };
    }
}