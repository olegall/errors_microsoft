// CS4032.cs (7,9)
using System.Collections.Generic;
using System.Threading.Tasks;

class C
{
    static IAsyncEnumerator<int> M(int value)
    {
        yield return value;
        await Task.CompletedTask;
    }
}


class C
{
    static async IAsyncEnumerator<int> M(int value)
    {
        yield return value;
        await Task.CompletedTask;
    }
}