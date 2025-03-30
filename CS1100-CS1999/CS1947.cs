// cs1947.cs  
using System.Linq;
class Test
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        var x = from i in array
                let k = i
                select i = 5; // CS1947  
        x.ToList();
    }
}