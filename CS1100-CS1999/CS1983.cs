// CS1983.cs (4,62)
using System.Collections.Generic;
using System.Threading.Tasks;

class C
{
    static async IEnumerable<int> M()
    {
        yield return await Task.FromResult(1);
    }
}