// cs1942.cs  
using System.Linq;
namespace _1942
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = from var i in Enumerable.Range(1, 100) // CS1949  
                    select i; //CS1942  
        }
    }
}