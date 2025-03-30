// cs1931.cs  
using System.Linq;

class Test
{
    static void Main()
    {
        int x = 1;
        var y = from x in Enumerable.Range(1, 100) // CS1931  
                select x;
    }
}