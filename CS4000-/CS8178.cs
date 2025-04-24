
using System.Threading.Tasks;

class TestClass
{
    int x;
    ref int Save(int y)
    {
        x = y;
        return ref x;
    }

    async Task TestMethod()
    {
        Save(1) = await Task.FromResult(0);
    }

    async Task TestMethod()
    {
        var x = await Task.FromResult(0);
        Save(1) = x;
    }
}