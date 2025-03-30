// cs1922.cs
public class Test
{
    public static void Main()
    {
        // Collection initializer.
        var tc = new TestClass { 1, "hello" }; // CS1922

        // Object initializer.
        var tc2 = new TestClass { memberA = 1, memberB = "hello" }; // OK
    }
}

public class TestClass
{
    public int memberA { get; set; }
    public string memberB { get; set; }
}