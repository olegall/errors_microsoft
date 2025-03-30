// cs1930.cs  
using System.Linq;
class Program
{
    static void Main()
    {
        int[] nums = { 0, 1, 2, 3, 4, 5 };
        var query = from num in nums
                    let num = 3 // CS1930  
                    select num;
    }
}