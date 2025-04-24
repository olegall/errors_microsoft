// cs1949.cs  

using System.Linq;
class Test
{
    static void Main()
    {
        var x = from var i in Enumerable.Range(1, 100) // CS1949  
                select i;
    }
}