// CS8159.cs (7,74)

using System.Linq;
class TestClass
{
    delegate ref char RefCharDelegate();
    void TestMethod()
    {
        var x = from c in "TestValue" select (RefCharDelegate)(() => ref c);
    }
}

class TestClass
{
    delegate char RefCharDelegate();
    void TestMethod()
    {
        var x = from c in "TestValue" select (RefCharDelegate)(() => c);
    }
}