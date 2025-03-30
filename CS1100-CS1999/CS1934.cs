// cs1934.cs  
using System.Linq;
using System.Collections;
static class Test
{
    public static void Main()
    {
        var list = new ArrayList { 0, 1, 2, 3, 4, 5 };
        var q = from x in list // CS1934  
                select x + 1;
    }
}