// cs1914.cs  
using System.Linq;
public class TestClass
{
    public string Message { get; set; }
    public static int Number { get; set; }
}
class Test
{
    static void Main()
    {
        TestClass b = new TestClass() { Message = "Hello", Number = "555-1212" }; // CS1914  

    }
}