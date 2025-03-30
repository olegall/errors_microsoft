using System.Collections.Generic;
class C
{
    void M(IAsyncEnumerable<int> collection)
    {
        await foreach (var i in collection)
        {
        }
    }
}

class C
{
    async void M(IAsyncEnumerable<int> collection)
    {
        await foreach (var i in collection)
        {
        }
    }
}