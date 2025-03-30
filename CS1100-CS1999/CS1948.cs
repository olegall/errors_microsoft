// cs1948.cs  
using System.Linq;
class Test
{
    public void TestMethod<T>(T t)
    {
        var x = from T in Enumerable.Range(1, 100) // CS1948  
                select T;
    }
}